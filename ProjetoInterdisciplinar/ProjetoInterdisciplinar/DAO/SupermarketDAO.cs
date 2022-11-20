using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable selectData(Supermarket supermarket)
        {
            DataTable dataTable = new DataTable();

            try
            {
                database.selectSupermarketQueryString();
                database.configureMySqlCommand();
                database.select();

                dataTable.Load(database.dataReader);

                DataRow row = dataTable.NewRow();
                row[dataTable.Columns[1].ColumnName] = "";
                dataTable.Rows.InsertAt(row, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }

            return dataTable;
        }
        public void insertData(Supermarket supermarket)
        {
            try
            {
                int idAddress = database.getNextId("address");

                AddressDAO addressDAO = new AddressDAO();
                bool didInsert = addressDAO.insertData(supermarket.address);

                if (didInsert)
                {
                    database.setInsertQueryString(Enums.QueryType.supermarket);
                    database.configureMySqlCommand();
                    database.command.Parameters.AddWithValue("@name", supermarket.name);
                    database.command.Parameters.AddWithValue("@idAddress", idAddress);
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
        public void updateData(Supermarket supermarket)
        {
            try
            {
                database.setUpdateSupermarketQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@name", supermarket.name);
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
        public bool deleteData(int idSupermarket)
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
        }
    }
}
