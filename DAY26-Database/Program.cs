// See https://aka.ms/new-console-template for more information
using DAY26_Database;

namespace ProgramEntityFrameWork
{
    public partial class Program
    {
        static void Main()
        {
            Northwind db = new Northwind();
            Console.WriteLine(db.Database.ProviderName);
        }
    }
}
