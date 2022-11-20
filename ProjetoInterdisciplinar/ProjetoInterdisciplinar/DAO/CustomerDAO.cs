﻿using MySql.Data.MySqlClient;
using ProjetoInterdisciplinar.Model;
using System;
using System.Windows.Forms;
using ProjetoInterdisciplinar.Helpers;
using System.Drawing;
using System.Data;

enum LoginResult
{
    success,
    invalide,
    failure
}

namespace ProjetoInterdisciplinar.DAO
{
    internal class CustomerDAO
    {
        private Database database;
        private LoginResult result;
        public string message;
        public CustomerDAO()
        {
            database = new Database();
        }

        public LoginResult verifyLogin(Customer customer)
        {
            try
            {
                database.selectLoginQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@login", customer.email);
                database.command.Parameters.AddWithValue("@password", customer.password);
                database.select();

                if (database.dataReader.HasRows)
                {
                    while(database.dataReader.Read())
                    {
                        customer.idCustomer = Int32.Parse(database.dataReader["idCustomer"].ToString());
                        customer.name = database.dataReader["name"].ToString();
                        customer.email = database.dataReader["email"].ToString();
                        result = LoginResult.success;
                    }
                }
                else
                {
                    result = LoginResult.invalide;
                }
            }
            catch(MySqlException)
            {
                this.message = "Erro com o Banco de Dados!!";
                result = LoginResult.failure;
            }
            finally
            {
               database.closeConnection();
            }
            return result;
        }
        public void insertData(Customer customer)
        {
            try
            {
                int idAddress = database.getNextId("address");
                
                AddressDAO addressDAO = new AddressDAO();
                bool didInsert = addressDAO.insertData(customer.address);

                if (didInsert)
                {
                    database.setInsertCustomerQueryString();
                    database.configureMySqlCommand();
                    database.command.Parameters.AddWithValue("@name", customer.name);
                    database.command.Parameters.AddWithValue("@email", customer.email);
                    database.command.Parameters.AddWithValue("@password", customer.password);
                    database.command.Parameters.AddWithValue("@idAddress", idAddress);
                    database.insert();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }
        public void updateData(Customer customer)
        {
            try
            {
                database.setUpdateCustomerQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@name", customer.name);
                database.command.Parameters.AddWithValue("@email", customer.email);
                database.command.Parameters.AddWithValue("@password", customer.password);
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
        public bool deleteData(int idCustomer)
        {
            bool didDelete;

            try
            {
                database.setDeleteCustomerQueryString();
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idCustomer", idCustomer);
                database.insert();
                didDelete = true;
            }
            catch(Exception ex)
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