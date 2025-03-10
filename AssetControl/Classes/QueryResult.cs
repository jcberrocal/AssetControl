using System.Collections.Generic;

namespace AssetControl.Classes
{
    internal class QueryResult<T>
    {
        public List<T> Data { get; set; }
        public string ErrorMessage { get; set; }
        public QueryResult()
        {
            Data = new List<T>();
            ErrorMessage = string.Empty;
        }
    }
}
