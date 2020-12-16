using ComparingORM.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace ComparingORM.Infrastructure.Repositories
{
    public class ConfigRepository : IConfigRepository
    {
        public string GetConnectionString(string key)
        {
            var conString = ConfigurationManager.ConnectionStrings[key];
            if (conString != null)
            {
                return conString.ConnectionString;
            }

            return string.Empty;
        }
    }
}
