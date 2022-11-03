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
    internal class CategoryDAO
    {
        private Database database;

        public CategoryDAO()
        {
            database = new Database();
        }

        public void insertData(Category category)
        {
            try
            {
                database.setInsertCategoryQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@Type", category.Type);
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
                database.command.Parameters.AddWithValue("@Type", category.Type);
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
            return true;
        }
    }
}
