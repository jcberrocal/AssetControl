using AssetControl.Classes;
using AssetControl.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Logic
{
    internal class Validator<T> where T : class
    {
        public void FormsValidation (T myObject)
        {
            try
            {
                //get object properties
                var properties = typeof (T).GetProperties ();
                foreach (var property in properties)
                {
                    //if property is Optional or Ignore, skip validation
                    if (Attribute.IsDefined(property, typeof(OptionalAttribute)) || Attribute.IsDefined(property, typeof(IgnoreAttribute)))
                    {
                        //do nothing
                    }
                    //if property is Combo, perform a different validation
                    else if (Attribute.IsDefined(property, typeof(ComboAttribute)))
                    {
                        int comboValue = (int)property.GetValue(myObject);
                        string translatedProperty;
                        if (comboValue == 0)
                        {
                            using (Translations translations = new Translations())
                            {
                                translatedProperty = translations.GetTranslation(property.Name);
                            }
                            throw new ValidationException($"El campo {translatedProperty} es obligatorio", property.Name);
                        }
                    }
                    else
                    {
                        var value = property.GetValue(myObject);
                        string translatedProperty;
                        //string validation
                        if (property.PropertyType == typeof(string))
                         {
                            if (string.IsNullOrEmpty(value?.ToString()))
                            {
                                using (Translations translations = new Translations())
                                {
                                    translatedProperty = translations.GetTranslation(property.Name);
                                }
                                throw new ValidationException($"El campo {translatedProperty} es obligatorio", property.Name);
                            }
                        }
                        else if (property.PropertyType == typeof(int))
                        {
                            if (!int.TryParse(value?.ToString(), out var val))
                            {
                                using (Translations translations = new Translations())
                                {
                                    translatedProperty = translations.GetTranslation(property.Name);
                                }
                                throw new ValidationException($"El campo {translatedProperty} debe ser un número entero", property.Name);
                            }
                            if ((int)value <= 0)
                            {
                                using (Translations translations = new Translations())
                                {
                                    translatedProperty = translations.GetTranslation(property.Name);
                                }
                                throw new ValidationException($"El campo {translatedProperty} debe ser un número mayor o igual a cero", property.Name);
                            }
                        }
                    }
                }
            }
            catch (ValidationException)
            {
                throw;
            }
        }
    }
}
