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
    internal class ProductDAO
    {
        private Database database;

        public ProductDAO()
        {
            database = new Database();
        }

        public void insertData(Product product)
        {
            try
            {
                int idCategory = database.getNextId("category");


                database.setInsertProductQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@name", product.name);
                database.command.Parameters.AddWithValue("@idCategory", idCategory);
                bool didInsert = database.insert();
                if (didInsert)
                {
                    CategoryDAO categoryDAO = new CategoryDAO();
                    categoryDAO.insertData(product.category);
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
        public void updateData(Product product)
        {
            try
            {
                database.setUpdateProductQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@name", product.name);
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
        public bool delete(int idProduct)
        {
            bool didDelete;

            try
            {
                database.setDeleteProductQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idProduct", idProduct);
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
