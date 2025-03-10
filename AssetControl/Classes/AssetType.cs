using System;

namespace AssetControl.Classes
{
    public class AssetType
    {
        [Optional]
        public int AssetTypeId { get; set; }
        public string TypeDescription { get; set; }
        [Optional]
        public DateTime? EndDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            AssetType anotherAssetType = (AssetType)obj;
            return TypeDescription == anotherAssetType.TypeDescription && EndDate == anotherAssetType.EndDate;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(TypeDescription, EndDate);
        }
    }
}
