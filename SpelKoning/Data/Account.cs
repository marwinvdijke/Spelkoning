using SQLite;
namespace SpelKoning.Data
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Voortgang { get; set; }
        public string Wachtwoord { get; set; }
    }
}
