using JsonFlatFileDataStore;
using LCC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCC.Library
{
    class OptimizeLibrary
    {
        private DataStore oFile;
        private List<StockModel> oStocks = new List<StockModel>();

        public OptimizeLibrary()
        {
            this.oFile = UtilsLibrary.getUserFile();
            this.getStockPerProject();
        }

        private dynamic getStockPerProject()
        {
            foreach (dynamic oItem in this.getMaterialsPerProject())
            {
                foreach (StockModel oStockItem in this.getStockPerMaterial(int.Parse(oItem.id.ToString())))
                {
                    this.oStocks.Add(oStockItem);
                }
            }
            MessageBox.Show(JsonConvert.SerializeObject(this.oStocks));
            return this.oStocks;
        }

        private dynamic getStockPerMaterial(int iMaterialId)
        {
            return this.oFile
                .GetCollection<StockModel>()
                .AsQueryable()
                .Where(e => e.material_id == iMaterialId)
                .ToList();
        }

        private dynamic getMaterialsPerProject()
        {
            return this.oFile
                .GetCollection<MaterialModel>()
                .AsQueryable()
                .Where(e => e.project_id == GLOBAL.iSelectedProjectId)
                .ToList();
        }
    }
}
