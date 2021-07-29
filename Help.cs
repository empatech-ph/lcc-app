using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC
{
    public partial class Help : MaterialForm
    {
        public Help()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }
    }
}
