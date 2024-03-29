﻿using LCC.Model;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCC
{
    class GLOBAL
    {
        public static int iSelectedProjectId = 0;
        public static int iSelectedMaterialId = 0;
        public static List<int> aCheckedMaterials = new List<int>();
        public static List<TempCurrentUseOptimizeType> oTempCurrentUseOptimizeType = new List<TempCurrentUseOptimizeType>();
        public static List<TempOptimizedModel> oTempOptimized = new List<TempOptimizedModel>();
        public static List<TempCutlengthModel> oTempCutlength = new List<TempCutlengthModel>();
        public static List<TempStocklengthModel> oTempStockLengthOptimized = new List<TempStocklengthModel>();
    }
}
