using SQLite;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GetLang
{
    public class Banco
    {
        public SQLiteAsyncConnection Database;

        public Banco()
        {
            Init();
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Musica>();
            Debug.WriteLine(result.ToString());
        }
    }
}
