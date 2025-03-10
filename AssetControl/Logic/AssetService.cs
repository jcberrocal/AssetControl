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
    internal class AssetService : IDisposable
    {
        private DataSet dsResult;
        
        public AssetService()
        {
            dsResult = new DataSet();
        }
        public void Dispose()
        {
            dsResult = null;
        }

        public QueryResult<AssetType> GetAssetTypes(string description, bool active)
        {
            QueryResult<AssetType> result = new QueryResult<AssetType>();
            List<AssetType> assetTypesList = new List<AssetType>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetAssetTypesData(description, active);
                result.ErrorMessage = dbm.errorMessage;
            }
            if (string.IsNullOrEmpty(result.ErrorMessage) || dsResult.Tables["AssetTypes"].Rows.Count > 0)
            {
                List<object> assetTypes = Utilities.ConvertDataSetToList(dsResult, typeof(AssetType));
                assetTypesList = assetTypes.Cast<AssetType>().ToList();
                result.Data = assetTypesList;
            }
            return result;
        }

        public string SaveAssetType(AssetType type, EditType editType)
        {
            string result = string.Empty;
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dbm.SaveAssetType(type, editType);
                result = dbm.errorMessage;
            }
            return result;
        }

        public QueryResult<Branch> GetBranches(string description, bool active)
        {
            QueryResult<Branch> result = new QueryResult<Branch>();
            List<Branch> branchesList = new List<Branch>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetBranchesData(description, active);
                result.ErrorMessage = dbm.errorMessage;
            }
            if (string.IsNullOrEmpty(result.ErrorMessage) || dsResult.Tables["Branches"].Rows.Count > 0)
            {
                List<object> branches = Utilities.ConvertDataSetToList(dsResult, typeof(Branch));
                branchesList = branches.Cast<Branch>().ToList();
                result.Data = branchesList;
            }
            return result;
        }

        public string SaveBranch(Branch branch, EditType editType)
        {
            string result = string.Empty;
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dbm.SaveBranch(branch, editType);
                result = dbm.errorMessage;
            }
            return result;
        }

        public QueryResult<AssetLocation> GetLocations(string description, bool active)
        {
            QueryResult<AssetLocation> result = new QueryResult<AssetLocation>();
            List<AssetLocation> locationsList = new List<AssetLocation>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetLocationsData(description, active);
                result.ErrorMessage = dbm.errorMessage;
            }
            if (string.IsNullOrEmpty(result.ErrorMessage) || dsResult.Tables["Locations"].Rows.Count > 0)
            {
                List<object> locations = Utilities.ConvertDataSetToList(dsResult, typeof(AssetLocation));
                locationsList = locations.Cast<AssetLocation>().ToList();
                result.Data = locationsList;
            }
            return result;
        }

        public string SaveLocation(AssetLocation location, EditType editType)
        {
            string result = string.Empty;
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dbm.SaveLocation(location, editType);
                result = dbm.errorMessage;
            }
            return result;
        }

        public QueryResult<Asset> GetAssets(AssetSearchOptions options)
        {
            QueryResult<Asset> result = new QueryResult<Asset>();
            List<Asset> assetsList = new List<Asset>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetAssetsData(options);
                result.ErrorMessage = dbm.errorMessage;
            }
            if (string.IsNullOrEmpty(result.ErrorMessage) && dsResult.Tables["Assets"].Rows.Count > 0)
            {
                List<object> assets = Utilities.ConvertDataSetToList(dsResult, typeof(Asset));
                assetsList = assets.Cast<Asset>().ToList();
                result.Data = assetsList;
            }
            return result;
        }

        public List<AssetType> GetAssetTypesList()
        {
            List<AssetType> assetTypeList = new List<AssetType>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetAssetTypesList();
            }
            List<object> assetTypes = Utilities.ConvertDataSetToList(dsResult, typeof(AssetType));
            assetTypeList = assetTypes.Cast<AssetType>().ToList();
            return assetTypeList;
        }

        public List<AssetStatus> GetAssetStatusesList()
        {
            List<AssetStatus> assetStatusList = new List<AssetStatus>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetAssetStatusesList();
            }
            List<object> assetStatuses = Utilities.ConvertDataSetToList(dsResult, typeof(AssetStatus));
            assetStatusList = assetStatuses.Cast<AssetStatus>().ToList();
            return assetStatusList;
        }

        public List<AssetLocation> GetLocationsList()
        {
            List<AssetLocation> locationList = new List<AssetLocation>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetAssetLocationsList();
            }
            List<object> locations = Utilities.ConvertDataSetToList(dsResult, typeof(AssetLocation));
            locationList = locations.Cast<AssetLocation>().ToList();
            return locationList;
        }

        public List<Branch> GetBranchesList()
        {
            List<Branch> branchList = new List<Branch>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetBranchesList();
            }
            List<object> branches = Utilities.ConvertDataSetToList(dsResult, typeof(Branch));
            branchList = branches.Cast<Branch>().ToList();
            return branchList;
        }

        public List<RetirementReason> GetRetirementReasonsList()
        {
            List<RetirementReason> retirementReasonList = new List<RetirementReason>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsResult = dbm.GetRetirementReasons();
            }
            List<object> reasons = Utilities.ConvertDataSetToList(dsResult, typeof(RetirementReason));
            retirementReasonList = reasons.Cast<RetirementReason>().ToList();
            return retirementReasonList;
        }

        public string SaveAsset(Asset asset, EditType editType)
        {
            string result = string.Empty;
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dbm.SaveAsset(asset, editType);
                result = dbm.errorMessage;
            }
            return result;
        }

        public static string CreateDetailsText(Asset newAsset, Asset oldAsset)
        {
            string details = $"Aseet Id: {newAsset.Id}\n";
            if (oldAsset.Description != newAsset.Description)
            {
                details += $"Description: {oldAsset.Description} -> {newAsset.Description}\n";
            }
            if (oldAsset.AssetType != newAsset.AssetType)
            {
                details += $"Asset Type: {oldAsset.AssetTypeDescription} -> {newAsset.AssetTypeDescription}\n";
            }
            if (oldAsset.Branch != newAsset.Branch)
            {
                details += $"Branch: {oldAsset.BranchDescription} -> {newAsset.BranchDescription}\n";
            }
            if (oldAsset.Location != newAsset.Location)
            {
                details += $"Location: {oldAsset.LocationDescription} -> {newAsset.LocationDescription}\n";
            }
            if (oldAsset.Price != newAsset.Price)
            {
                details += $"Price: {oldAsset.Price} -> {newAsset.Price}\n";
            }
            if (oldAsset.Status != newAsset.Status)
            {
                details += $"Status: {oldAsset.StatusDescription} -> {newAsset.StatusDescription}\n";
            }
            if (oldAsset.SerialNumber != newAsset.SerialNumber)
            {
                details += $"Serial Number: {oldAsset.SerialNumber} -> {newAsset.SerialNumber}\n";
            }
            if (oldAsset.AssetTag != newAsset.AssetTag)
            {
                details += $"Asset Tag: {oldAsset.AssetTag} -> {newAsset.AssetTag}\n";
            }
            if (oldAsset.GenericAsset != newAsset.GenericAsset)
            {
                details += $"Generic Asset: {oldAsset.GenericAsset} -> {newAsset.GenericAsset}\n";
            }
            if (oldAsset.Quantity != newAsset.Quantity)
            {
                details += $"Quantity: {oldAsset.Quantity} -> {newAsset.Quantity}\n";
            }
            if (oldAsset.PurchaseDate != newAsset.PurchaseDate)
            {
                details += $"Purchase Date: {oldAsset.PurchaseDate} -> {newAsset.PurchaseDate}\n";
            }
            if (oldAsset.WarrantyMonths != newAsset.WarrantyMonths)
            {
                details += $"Warranty Months: {oldAsset.WarrantyMonths} -> {newAsset.WarrantyMonths}\n";
            }
            if (oldAsset.Observations != newAsset.Observations)
            {
                details += $"Observations: {oldAsset.Observations} -> {newAsset.Observations}\n";
            }
            return details;
        }
    }
}
