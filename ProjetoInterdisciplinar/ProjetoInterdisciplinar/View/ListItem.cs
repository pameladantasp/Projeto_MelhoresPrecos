using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class ListItem : UserControl
    {
        public string UserName { get; set; }
        public string DescriptionProduct { get; set; }
        public string SupermarketName { get; set; }
        public string Price { get; set; }

        public ListItem()
        {
            InitializeComponent();
        }

        private void ListItem_Load(object sender, System.EventArgs e)
        {
            lbUserName.Text = UserName;
            lbDescriptionProduct.Text = DescriptionProduct;
            lbNameSupermarket.Text = SupermarketName;
            lbPrice.Text = Price;
            lbPrice.Text = Price;
        }
    }
}
