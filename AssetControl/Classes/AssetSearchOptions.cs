using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Classes
{
    internal class AssetSearchOptions
    {
        public AssetSearchOptions()
        {
            GenericAsset = false;
            ActiveOnly = true;
        }

        public string Description { get; set; }
        public int AssetType { get; set; }
        public int Status { get; set; }
        public int Location { get; set; }
        public int Branch { get; set; }
        public bool GenericAsset { get; set; }
        public bool ActiveOnly { get; set; }
        public string AssetTag { get; set; }

    }
}
