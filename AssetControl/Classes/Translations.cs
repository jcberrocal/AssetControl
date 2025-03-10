using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Classes
{
    public class Translations : IDisposable
    {
        private Dictionary<string, string> _propertyTranslations = new Dictionary<string, string>();
        
        public Translations()
        {
            _propertyTranslations = new Dictionary<string, string>()
            {
                { "Description", "Descripción" },
                { "AssetType", "Tipo de Activo" },
                { "Status", "Estado" },
                { "Location", "Ubicación" },
                { "Branch", "Filial" },
                { "Price", "Precio" },
                { "Observations", "Observaciones" },
                { "SerialNumber", "Número de Serie" },
                { "AssetTag", "Etiqueta de Activo" },
                { "Quantity", "Cantidad" },
                { "PurchaseDate", "Fecha de Compra" },
                { "WarrantyMonths", "Meses de Garantía" },
                { "LocationDescription", "Descripción" },
                { "TypeDescription", "Descripción" },
                { "BranchDescription", "Descripción" },
                { "UserId", "Usuario" },
                { "UserName", "Nombre" },
                { "Password", "Contraseña" },
                { "Role", "Perfil" }
            }; 
        }

        public string GetTranslation(string propertyName)
        {
            if (!_propertyTranslations.ContainsKey(propertyName))
            {
                return propertyName;
            }
            else
            {
                return _propertyTranslations[propertyName];
            }
        }

        public void Dispose()
        {
            _propertyTranslations = null;
        }
    }
}
