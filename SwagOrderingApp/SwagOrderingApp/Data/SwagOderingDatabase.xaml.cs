using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;


namespace SwagOrderingApp.Data
{
    public class SwagOderingDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<SwagOderingDatabase> Instance = new AsyncLazy<SwagOderingDatabase>(async () =>
         {
             var instance = new SwagOderingDatabase();
             CreateTableResult result = await Database.CreateTableAsync<SwagOrdering>();
             return instance;
         });

        public SwagOderingDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<SwagOrdering>> GetItemsAsync()
        {
            return Database.Table<SwagOrdering>().ToListAsync();
        }

        public Task<List<SwagOrdering>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<SwagOrdering>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<SwagOrdering> GetItemAsync(int id)
        {
            return Database.Table<SwagOrdering>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }



        public Task<int> SaveItemAsync(SwagOrdering item)
    {
        if (item.ID != 0)
        {
            return Database.UpdateAsync(item);
        }
        else
        {
            return Database.InsertAsync(item);
        }
    }

}
}