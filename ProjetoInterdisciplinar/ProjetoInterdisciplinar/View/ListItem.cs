using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }


        public string UserName { get; set; }
        public string DescriptionProduct { get; set; }
        public string SupermarketName { get; set; }
        public string Price { get; set; }

    }
}
