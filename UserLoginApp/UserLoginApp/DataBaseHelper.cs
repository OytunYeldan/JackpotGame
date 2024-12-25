using System.Data.SQLite;

public static class DatabaseHelper
{
    private static readonly string connectionString = @"Data Source=C:\Users\oytun\Desktop\Db\SlotGame_Db.db;Version=3;";

    public static SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(connectionString);
    }
}
