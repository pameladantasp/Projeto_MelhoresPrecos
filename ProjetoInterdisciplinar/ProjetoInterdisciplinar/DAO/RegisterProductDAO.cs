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
                int idProduct = database.getNextId("product");

                database.setInsertProductQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@name", registerProduct.product.name);
                database.command.Parameters.AddWithValue("@category", registerProduct.product.category.idCategory);
                bool didInsert = database.insert();
                
                if (didInsert)
                {
                    database.closeConnection();
                    database.setInsertRegisterProductQueryString();
                    database.configureMySqlCommand();
                    database.command.Parameters.AddWithValue("@idCustomer", registerProduct.customer.idCustomer);
                    database.command.Parameters.AddWithValue("@idCategory", registerProduct.product.category.idCategory);
                    database.command.Parameters.AddWithValue("@idProduct", idProduct);
                    database.command.Parameters.AddWithValue("@idSupermarket", registerProduct.supermarket.idSupermarket);
                    database.command.Parameters.AddWithValue("@price", registerProduct.price);
                    database.command.Parameters.AddWithValue("@dateRegister", Convert.ToDateTime(registerProduct.dateRegister).ToString("yyyy/MM/dd"));
                    database.insert();
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
                database.command.Parameters.AddWithValue("@dataRegister", registerProduct.dateRegister);
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
