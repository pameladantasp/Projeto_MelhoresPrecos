﻿using ProjetoInterdisciplinar.Helpers;
using ProjetoInterdisciplinar.Model;
using System;
using static ProjetoInterdisciplinar.Helpers.Enums;

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
                database.setInsertQueryString(Enums.QueryType.address);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@street", address.street);
                database.command.Parameters.AddWithValue("@number", address.number);
                database.command.Parameters.AddWithValue("@district", address.district);
                database.command.Parameters.AddWithValue("@city", address.city);
                database.command.Parameters.AddWithValue("@state", address.state);
                database.command.Parameters.AddWithValue("@postalCode", address.postalCode);
                database.insert();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                database.setUpdateQueryString(QueryType.address);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@street", address.street);
                database.command.Parameters.AddWithValue("@number", address.number);
                database.command.Parameters.AddWithValue("@district", address.district);
                database.command.Parameters.AddWithValue("@city", address.city);
                database.command.Parameters.AddWithValue("@state", address.state);
                database.command.Parameters.AddWithValue("@postalCode", address.postalCode);
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

        public bool delete(int idAddress)
        {
            bool didDelete;

            try
            {
                database.setDeleteQueryString(QueryType.address);
                database.configureMySqlCommand();
                database.command.Parameters.AddWithValue("@idAddress", idAddress);
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
