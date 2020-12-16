using ComparingORM.Core.Entities;
using ComparingORM.Core.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ComparingORM.Infrastructure.Repositories
{
    public class PersonRepositoryDapper : IPersonRepository
    {
        private readonly IConfigRepository _configRepository;
        private readonly IConfiguration _config;

        public PersonRepositoryDapper(IConfigRepository configRepository, IConfiguration config)
        {
            _configRepository = configRepository;
            _config = config;
        }

        public async Task<IEnumerable<Person>> GetPerson()
        {
            const string query = @"Select * From Person";

            
            using (var conn = new SqlConnection(_config.GetConnectionString("DevConnection")))
            {
                conn.Open();
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var persons = await conn.QueryAsync<Person>(query);
                stopwatch.Stop();
                Console.WriteLine("Dapper.Net: {0} registros obtenidos en {1} milisegundos.", persons.AsList().Count, stopwatch.ElapsedMilliseconds);
                return persons.AsList();

            }

        }
    }
}
