using ProjetoInterdisciplinar.Controller;
using System;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.View
{
    public partial class ConfigurationView : Form
    {
        private ConfigurationController configurationController;

        public ConfigurationView()
        {
            InitializeComponent();
            configurationController = new ConfigurationController();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            configurationController.closeView(this);
            configurationController.navigateToHomeView();
        }
    }
}
