// Author: wuchenyang(shpkng@gmail.com) 

using FF.Utils;
using SQLite;

public class DBManager : Singleton<DBManager>
{
    private DBManager _instance;
    private SQLiteConnection connection;

    public DBManager Init(string path)
    {
        connection = new SQLiteConnection(path);
        return this;
    }

    public DBManager Release()
    {
        connection.Close();
        return this;
    }

    public DBManager CreateTable<T>()
    {
        connection.CreateTable<T>();
        return this;
    }

    public bool Get<T>(int id, out T result) where T : DataItem
    {
        result = null;
        if (connection == null)
            return false;

        return true;
    }

    public bool Remove<T>(int id)
    {
        return true;
    }

    public bool Update(int id)
    {
        return true;
    }

    public bool Reset(int id)
    {
        return true;
    }

    public bool Save(int id)
    {
        return true;
    }
}