using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingORM.Core.Interfaces
{
    public interface IConfigRepository
    {
        public string GetConnectionString(string key);
    }
}
