using SQLite;

namespace SwagOrderingApp
{
    public class SwagOrdering
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        public int OrderId { get; set; }

        public string Gender { get; set; }

    }
}
