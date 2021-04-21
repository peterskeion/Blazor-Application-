using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IsqlDataAcess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}