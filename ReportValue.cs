using System;
using System.Collections.Generic;
using System.Text;

namespace LCC
{
    class ReportValue
    {
        public string RPT_Title { get; set; }
        public string CutLengthRPT_LabelContent { get; set; }
        public string CutLengthRPT_PartLength { get; set; }
        public string CutLengthRPT_PartCode { get; set; }
        public string CutLengthRPT_MaterialDesc { get; set; }
        public string MaterialRPT_ProjectNumber { get; set; }
        public string MaterialRPT_Scope { get; set; }
        public string MaterialRPT_Rev { get; set; }
        public string MaterialRPT_Material { get; set; }
        public string MaterialRPT_Grade{ get; set; }
        public string MaterialRPT_Qty { get; set; }
        public string MaterialRPT_Length { get; set; }
        public string MaterialRPT_UnitCost { get; set; }
        public string MaterialRPT_TotalCost { get; set; }
        public string MaterialRPT_StockCode { get; set; }
        public string MaterialRPT_Note { get; set; }
        public string NestingRPT_Project { get; set; } //reuse in material report
        public string NestingRPT_Date { get; set; } //reuse in material report
        public string NestingRPT_Note { get; set; }
        public string NestingRPT_Cost{ get; set; }
        public string NestingRPT_Yield { get; set; }
        public string NestingRPT_GrossYield { get; set; }
        public string NestingRPT_Stocks { get; set; }
        public string NestingRPT_Parts { get; set; }
        public string NestingRPT_Layouts { get; set; }
        public string NestingRPT_UncutParts { get; set; }
        public string NestingRPT_Kerf { get; set; }
        public string NestingRPT_PartIncrease { get; set; }
        public string NestingRPT_LeftTrim { get; set; }
        public string NestingRPT_RightTrim { get; set; }
        public string NestingRPT_MinRemnantLength { get; set; }
        public string NestingRPT_RemStorage { get; set; }

    }
}
