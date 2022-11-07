using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.DAO
{
    internal class RegisterProductDAO
    {
        private Database database;
        public RegisterProductDAO()
        {
            database = new Database();
        }

        public void insertData(RegisterProduct registerProduct)
        {
            try
            {
                int idCustomer = database.getNextId("customer");
                int idProduct = database.getNextId("product");
                int idSupermarket = database.getNextId("supermarket");

                database.setInsertRegisterProductQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idCustomer", idCustomer);
                database.command.Parameters.AddWithValue("@idProduct", idProduct);
                database.command.Parameters.AddWithValue("@idSupermarket", idSupermarket);
                database.command.Parameters.AddWithValue("@price", registerProduct.price);
                database.command.Parameters.AddWithValue("@dataRegister", registerProduct.dataRegister);

                bool didInsert = database.insert();
                if (didInsert)
                {
                    CustumerDAO custumerDAO = new CustumerDAO();
                    custumerDAO.insertData(registerProduct.customer);

                    ProductDAO productDAO = new ProductDAO();
                    productDAO.insertData(registerProduct.product);

                    SupermarketDAO supermarketDAO = new SupermarketDAO();
                    supermarketDAO.insertData(registerProduct.supermarket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }
        public void updateData(RegisterProduct registerProduct)
        {
            try
            {
                database.setUpdateRegisterProductQueryString();
                database.configureMySqlCommand(); 
                database.command.Parameters.AddWithValue("@price", registerProduct.price);
                database.command.Parameters.AddWithValue("@dataRegister", registerProduct.dataRegister);
                database.insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }
        public bool delete(int idRegisterProduct)
        {
            bool didDelete;

            try
            {
                database.setDeleteRegisterProductQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idRegister", idRegisterProduct);
                database.insert();
                didDelete = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                didDelete = false;
            }
            finally
            {
                database.closeConnection();
            }
            return didDelete;
        }
    }
}
