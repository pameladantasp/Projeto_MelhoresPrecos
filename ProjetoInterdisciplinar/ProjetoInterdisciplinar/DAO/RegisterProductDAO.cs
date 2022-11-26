using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ProjetoInterdisciplinar.Helpers.Enums;

namespace ProjetoInterdisciplinar.DAO
{
    internal class RegisterProductDAO
    {
        private Database database;
        private ErrorResult result;
        private RegisterProduct registerProduct;
        private int limiter = 20;
        public RegisterProductDAO()
        {
            database = new Database();
        }

        public List<RegisterProduct> selectData()
        {
            List<RegisterProduct> registerProductList = new List<RegisterProduct>();

            try
            {
                database.selectRegisterProductQueryString(WhereType.limit);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@limit", limiter);
                database.select();

                if (database.dataReader.HasRows)
                {
                    while (database.dataReader.Read())
                    {
                        registerProduct = new RegisterProduct();

                        registerProduct.customer = new Customer();
                        registerProduct.customer.name = database.dataReader["customerName"].ToString();

                        registerProduct.supermarket = new Supermarket();
                        registerProduct.supermarket.name = database.dataReader["supermarketName"].ToString();

                        registerProduct.product = new Product();
                        registerProduct.product.name = database.dataReader["productDescription"].ToString();

                        registerProduct.price = (float)database.dataReader["price"];

                        registerProductList.Add(registerProduct);
                    }
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
            return registerProductList;
        }

        public ErrorResult insertData(RegisterProduct registerProduct)
        {
            try
            {
                int idProduct = database.getNextId("product");

                database.setInsertQueryString(Enums.QueryType.product);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@name", registerProduct.product.name);
                database.command.Parameters.AddWithValue("@category", registerProduct.product.category.idCategory);
                bool didInsert = database.insert();
                
                if (didInsert)
                {
                    database.closeConnection();
                    database.setInsertQueryString(Enums.QueryType.registerProduct);
                    database.configureMySqlCommand();
                    database.command.Parameters.AddWithValue("@idCustomer", registerProduct.customer.idCustomer);
                    database.command.Parameters.AddWithValue("@idCategory", registerProduct.product.category.idCategory);
                    database.command.Parameters.AddWithValue("@idProduct", idProduct);
                    database.command.Parameters.AddWithValue("@idSupermarket", registerProduct.supermarket.idSupermarket);
                    database.command.Parameters.AddWithValue("@price", registerProduct.price);
                    database.command.Parameters.AddWithValue("@dateRegister", Convert.ToDateTime(registerProduct.dateRegister).ToString("yyyy/MM/dd"));
                    database.insert();
                    result = ErrorResult.success;
                }
                else
                {
                    result = ErrorResult.failure;
                }
            }
            catch (Exception ex)
            {
                result = ErrorResult.failure;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
            return result;
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
        public bool deleteData(int idRegisterProduct)
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
