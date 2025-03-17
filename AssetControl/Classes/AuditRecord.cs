using System;

namespace AssetControl.Classes
{
    public class AuditRecord
    {
        public int LogId {  get; set; }
        public DateTime LogDate { get; set; }
        public string UserId { get; set; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public string RecordId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Details { get; set; }
    }
}
