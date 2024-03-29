﻿using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using System;
using System.Data;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.DAO
{
    internal class CategoryDAO
    {
        private Database database;
        
        public CategoryDAO()
        {
            database = new Database();
        }

        public DataTable selectData()
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
                Console.WriteLine(ex.Message);
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
                database.setInsertQueryString(Enums.QueryType.category);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@type", category.type);
                database.insert();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                database.setUpdateQueryString(QueryType.category);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@type", category.type);
                database.insert();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }

        public bool deleteData(int idCategory)
        {
            bool didDelete;

            try
            {
                database.setDeleteQueryString(QueryType.category);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idCategroy", idCategory);
                database.insert();
                didDelete = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
