using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoInterdisciplinar.View;

namespace ProjetoInterdisciplinar.View
{
    public partial class FinallyView : Form
    {
        public FinallyView()
        {
            InitializeComponent();
        }

        private void FinallyView_Load(object sender, EventArgs e)
        {
            poplateItems();
        }

        private void poplateItems()
        {
            ListItem[] listItems = new ListItem[20];

            for (int i = 0; i < listItems.Length; i++)
            {

                listItems[i] = new ListItem();
                listItems[i].UserName = "Pamela Dantas";
                listItems[i].DescriptionProduct = "Refrigerante Coca Cola Pet 3L";
                listItems[i].SupermarketName = "Supermercado Enxuto";
                listItems[i].Price = "R$ 9.99";

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            }
        }
    }
}
