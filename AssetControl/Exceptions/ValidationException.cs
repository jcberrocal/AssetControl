using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Exceptions
{
    internal class ValidationException : Exception
    {
        public string PropertyName { get; }
        public ValidationException(string message, string propertyName) : base (message)
        {
            PropertyName = propertyName;
        }
    }
}
