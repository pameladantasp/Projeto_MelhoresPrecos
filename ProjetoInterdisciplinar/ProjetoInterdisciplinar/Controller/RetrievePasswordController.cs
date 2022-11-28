using ProjetoInterdisciplinar.View;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.Controller
{
    internal class RetrievePasswordController
    {

        Thread t1;

        public void navigateToLoginView()
        {
            setThread(new Thread(openLoginScreen));
        }

        private void setThread(Thread thread)
        {
            t1 = thread;
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void openLoginScreen()
        {
            Application.Run(new LoginView());
        }

        public void closeView(Form form)
        {
            form.Close();
        }
    }
}
