using System;

namespace AssetControl.Classes
{
    internal class AssetLocation
    {
        [Optional]
        public int AssetLocationId { get; set; }
        public string LocationDescription { get; set; }
        [Optional]
        public DateTime? EndDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            AssetLocation anotherLocation = (AssetLocation)obj;
            return LocationDescription == anotherLocation.LocationDescription && EndDate == anotherLocation.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LocationDescription, EndDate);
        }
    }
}
