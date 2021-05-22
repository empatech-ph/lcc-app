using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LCC.Library
{
    class ThemeLibrary
    {
        public static void initMaterialDesign(MaterialForm oForm)
        {
            MaterialSkinManager oMaterialSkinManager = MaterialSkinManager.Instance;
            oMaterialSkinManager.AddFormToManage(oForm);
            oMaterialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            oMaterialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo100,
                Accent.Blue400,
                TextShade.WHITE
            );
        }
    }
}
