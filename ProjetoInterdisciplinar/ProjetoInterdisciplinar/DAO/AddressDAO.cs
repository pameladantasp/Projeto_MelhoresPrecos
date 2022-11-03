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
    internal class AddressDAO
    {
        private Database database;

        public AddressDAO()
        {
            database = new Database();
        }

        public bool insertData(Address address)
        {
            try
            {
                database.setInsertAddressQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@Street", address.Street);
                database.command.Parameters.AddWithValue("@Number", address.Number);
                database.command.Parameters.AddWithValue("@City", address.City);
                database.command.Parameters.AddWithValue("@State", address.State);
                database.command.Parameters.AddWithValue("@Postalcode", address.PostalCode);
                database.insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                database.closeConnection();
            }
            return true;
        }

        public void updateData(Address address)
        {
            try
            {
                database.setUpdateAddressQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@Street", address.Street);
                database.command.Parameters.AddWithValue("@Number", address.Number);
                database.command.Parameters.AddWithValue("@City", address.City);
                database.command.Parameters.AddWithValue("@State", address.State);
                database.command.Parameters.AddWithValue("@Postalcode", address.PostalCode);
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

        public bool delete(int idAddress)
        {
            bool didDelete;

            try
            {
                database.setDeleteAddressQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idAddress", idAddress);
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
