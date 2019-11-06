using SQLitePCL;

namespace bai_thi_uwp.Ultils
{
    internal class SQLiteUtilc
    {

        private const string DatabaseName = "baithinew.db";



        private static SQLiteUtilc _instance;

        public SQLiteConnection Connection { get; }



        public static SQLiteUtilc GetIntances()

        {

            if (_instance == null)

            {

                _instance = new SQLiteUtilc();

            }

            return _instance;

        }



        private SQLiteUtilc()

        {

            Connection = new SQLiteConnection(DatabaseName);

            CreateTables();

        }



        private void CreateTables()

        {

            string sql = @"CREATE TABLE IF NOT EXISTS Contact (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ),PhoneNumber VARCHAR( 140 ));";

            using (var statement = Connection.Prepare(sql))

            {

                statement.Step();

            }

        }

    }
}