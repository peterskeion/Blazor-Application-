﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class sqlDataAcess : IsqlDataAcess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "Default";
        public sqlDataAcess(IConfiguration config)
        {

            _config = config;
            Console.WriteLine("Test");
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {

            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {

            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                var data = await connection.QueryAsync<T>(sql, parameters);

                await connection.ExecuteAsync(sql, parameters);
            }
        }





    }
}
