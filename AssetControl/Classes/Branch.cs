using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Classes
{
    internal class Branch
    {
        [Optional]
        public int BranchId { get; set; }
        public string BranchDescription { get; set; }
        [Optional]
        public DateTime? EndDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Branch anotherBranch = (Branch)obj;
            return BranchDescription == anotherBranch.BranchDescription && EndDate == anotherBranch.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BranchDescription, EndDate);
        }
    }
}
