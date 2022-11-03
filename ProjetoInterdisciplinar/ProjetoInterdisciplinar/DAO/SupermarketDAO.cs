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
    internal class SupermarketDAO
    {
        private Database database;
        public SupermarketDAO()
        {
            database = new Database();
        }
        public void insertData(Supermarket supermarket)
        {
            try
            {
                int idAddress = database.getNextId("address");

                database.setInsertSupermarketQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@Name", supermarket.Name);
                database.command.Parameters.AddWithValue("@idAddress", idAddress);
                bool didInsert = database.insert();
                if (didInsert)
                {
                    AddressDAO addressDAO = new AddressDAO();
                    addressDAO.insertData(supermarket.address);
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
        public void updateData(Supermarket supermarket)
        {
            try
            {
                database.setUpdateSupermarketQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@Name", supermarket.Name);
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
        public bool delete(int idSupermarket)
        {
            bool didDelete;

            try
            {
                database.setDeleteSupermarketQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idSupermarket", idSupermarket);
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
            return true;
        }
    }
}
