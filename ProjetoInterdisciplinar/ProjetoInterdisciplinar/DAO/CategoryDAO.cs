using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CategoryDAO
    {
        private Database database;
        

        public CategoryDAO()
        {
            database = new Database();
        }

        public DataTable selectData(Category category)
        {
            DataTable dataTable = new DataTable();

            try
            {
                database.selectCategoryQueryString();
                database.configureMySqlCommand();
                database.select();
    
                dataTable.Load(database.dataReader);
    
                DataRow row = dataTable.NewRow();
                row[dataTable.Columns[1].ColumnName] = "";
                dataTable.Rows.InsertAt(row, 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }

            return dataTable;
        }

        public void insertData(Category category)
        {
            try
            {
                database.setInsertCategoryQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@type", category.type);
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

        public void updateData(Category category)
        {
            try
            {
                database.setUpdateCategoryQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@type", category.type);
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

        public bool delete(int idCategory)
        {
            bool didDelete;

            try
            {
                database.setDeleteCategoryQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idCategroy", idCategory);
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
