using System;

namespace AssetControl.Classes
{
    public class Asset
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [Combo]
        public int AssetType { get; set; }
        [Optional]
        public string AssetTypeDescription { get; set; }
        [Combo]
        public int Status { get; set; }
        [Optional]
        public string StatusDescription { get; set; }
        [Combo]
        public int Location { get; set; }
        [Optional]
        public string LocationDescription { get; set; }
        [Combo]
        public int Branch { get; set; }
        [Optional]
        public string BranchDescription { get; set; }
        public decimal? Price { get; set; }        
        [Optional]
        public string Observations { get; set; }
        [Optional]
        public string SerialNumber { get; set; }
        [Optional]
        public string AssetTag { get; set; }
        [Ignore]
        public bool GenericAsset { get; set; }
        public int Quantity { get; set; }
        [Optional]
        public DateTime? PurchaseDate { get; set; }
        [Optional]
        public DateTime? EndDate { get; set; }
        [Optional]
        public string EndateNote { get; set; }
        [Optional]
        public int? WarrantyMonths { get; set; }
        [Optional]
        public int? RetirementReason { get; set; }
        [Optional]
        public string RetirementReasonDescription { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Asset anotherAsset = (Asset)obj;
            return Description == anotherAsset.Description && AssetType == anotherAsset.AssetType 
                && Status == anotherAsset.Status && Location == anotherAsset.Location 
                && Branch == anotherAsset.Branch && SerialNumber == anotherAsset.SerialNumber
                && AssetTag == anotherAsset.AssetTag && Price == anotherAsset.Price
                && Observations == anotherAsset.Observations && GenericAsset == anotherAsset.GenericAsset
                && Quantity == anotherAsset.Quantity && PurchaseDate == anotherAsset.PurchaseDate
                && WarrantyMonths == anotherAsset.WarrantyMonths;
        }

        public override int GetHashCode()
        {
            int hash1 = HashCode.Combine(Description, AssetType, Status, Location, Branch, SerialNumber, AssetTag, Price);
            int hash2 = HashCode.Combine(hash1, Observations, GenericAsset, Quantity, PurchaseDate, WarrantyMonths);
            return hash2;
        }
    }
}
