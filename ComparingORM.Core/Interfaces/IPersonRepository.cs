using ComparingORM.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComparingORM.Core.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPerson();
    }
}
