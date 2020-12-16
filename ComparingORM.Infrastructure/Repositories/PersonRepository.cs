using ComparingORM.Core.Entities;
using ComparingORM.Core.Interfaces;
using ComparingORM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ComparingORM.Infrastructure.Repositories
{
    public class PersonRepository: IPersonRepository
    {
        private readonly SampleORMContext _context;

        public PersonRepository(SampleORMContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetPerson()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var persons = await _context.Person.AsNoTracking().ToListAsync();
            stopwatch.Stop();
            Console.WriteLine("EF Core   : {0} registros obtenidos en {1} milisegundos.", persons.Count, stopwatch.ElapsedMilliseconds);
            return persons;
        }
    }
}
