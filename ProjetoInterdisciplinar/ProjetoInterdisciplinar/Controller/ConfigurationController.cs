using ProjetoInterdisciplinar.View;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Controller
{
    internal class ConfigurationController
    {
        Thread t1;

        public void navigateToHomeView()
        {
            setThread(new Thread(openHomeScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openHomeScreen(object obj)
        {
            Application.Run(new HomeView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }
    }
}
