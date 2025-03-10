using AssetControl.Classes;
using AssetControl.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Logic
{
    internal class Utilities
    {
        private static Dictionary<Type, Func<object>> _constructor = new Dictionary<Type, Func<object>>()
        {
            //{ typeof(User), () => User.Instance },
            { typeof(User), () => User.CreateNewUser() },
        };

        public static bool TestDBConnection()
        {
            using(DataBaseManager dbm = new DataBaseManager())
            {
                bool connected = dbm.TestConnection();
                return connected;
            }            
        }

        public static void SaveAuditRecord(AuditRecord record)
        {
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dbm.SaveAuditRecord(record);
            }
        }

        public static List<object> GetCombosData(Type type)
        {
            List<object> roles = new List<object>();

            return roles;
        }

        public static List<object> ConvertDataSetToList(DataSet ds, Type type)
        {
            List<object> list = new List<object>();
            try
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    object myObject;
                    if (_constructor.ContainsKey(type))
                    {
                        Func<object> constructor = _constructor[type];
                        myObject = constructor();
                    }
                    else
                        myObject = Activator.CreateInstance(type);
                    var properties = type.GetProperties();
                    foreach (var property in properties)
                    {
                        if (Attribute.IsDefined(property, typeof(IgnoreAttribute)))
                        {
                            continue;
                        }
                        string columnName = property.Name;
                        object columnValue = row[columnName];
                        if (Convert.IsDBNull(columnValue))
                        {
                            if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                            {
                                property.SetValue(myObject, null);
                            }
                            else
                            {
                                property.SetValue(myObject, string.Empty);
                            }
                        }
                        else
                        {
                            if (property.PropertyType.IsGenericType &&
                                property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            {
                                Type baseType = Nullable.GetUnderlyingType(property.PropertyType);
                                property.SetValue(myObject, Convert.ChangeType(columnValue, baseType));
                            }
                            else
                                property.SetValue(myObject, Convert.ChangeType(columnValue, property.PropertyType));
                        }
                    }
                    list.Add(myObject);
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception($"Error: {ex.Message}");
            }
            return list;
        }
    }
}
