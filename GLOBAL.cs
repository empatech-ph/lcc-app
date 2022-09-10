using JsonFlatFileDataStore;
using LCC.Library;
using LCC.Model;
using MaterialSkin;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LCC
{
    class GLOBAL
    {
        public static int iSelectedProjectId = 0;
        public static int iSelectedMaterialId = 0;
        public static string sSelectedGrade = "";
        public static string sSelectedDescription = "";
        public static List<int> aCheckedMaterials = new List<int>();
        public static List<TempCurrentUseOptimizeType> oTempCurrentUseOptimizeType = new List<TempCurrentUseOptimizeType>();
        public static List<TempOptimizedModel> oTempOptimized = new List<TempOptimizedModel>();
        public static List<TempCutlengthModel> oTempCutlength = new List<TempCutlengthModel>();
        public static List<TempStocklengthModel> oTempStockLengthOptimized = new List<TempStocklengthModel>();

        public static OptionSettingsModel getOptions() {

            DataStore oFile = UtilsLibrary.getUserFile();
            var oCollection = oFile.GetCollection<OptionSettingsModel>().AsQueryable();
            if (oCollection.ToList().Count <= 0)
            {
                return new OptionSettingsModel();
            }
            return oCollection.First();
        }
    }
}
