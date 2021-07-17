// Author: wuchenyang(shpkng@gmail.com) 

using System.Collections.Generic;
using System.IO;
using FF.Utils;
using SQLite;
using UnityEngine;

public class DBManager : Singleton<DBManager>
{
    #region properties

    private const string defaultDataName = "default.db";
    private const string userDataName = "current.db";
    private const string userDataFolderName = "UserData";
    private static string _defaultDataPath;
    private static string _userDataFolderPath;
    private static string _userDataPath;

    public static string defaultDataPath =>
        _defaultDataPath ??= Path.Combine(Application.streamingAssetsPath, defaultDataName);

    private static string userDataFolderPath =>
        _userDataFolderPath ??= Path.Combine(Application.persistentDataPath, userDataFolderName);

    private static string userDataPath => _userDataPath ??= Path.Combine(Application.persistentDataPath, userDataName);

    private static bool defaultDataExists => File.Exists(defaultDataPath);

    private static bool userDataExisting => File.Exists(userDataPath);

    #endregion

    public static bool CopyDefault(bool ignoreExisting = false)
    {
        if (!defaultDataExists)
        {
            Debug.LogError("Default data is not available!");
            return false;
        }

        if (!ignoreExisting && userDataExisting)
        {
            Debug.LogError($"{userDataPath} exists!");
            return false;
        }

        if (!Directory.Exists(userDataFolderPath))
        {
            Directory.CreateDirectory(userDataFolderPath);
        }

        File.Copy(defaultDataPath, userDataPath);
        return true;
    }

    private SQLiteConnection connection;

    public DBManager Init(string path)
    {
        connection = new SQLiteConnection(path);
        return this;
    }

    public DBManager Release()
    {
        connection?.Close();
        return this;
    }

#if UNITY_EDITOR
    public DBManager CreateTable<T>()
    {
        if (connection == null)
            return this;
        connection.CreateTable<T>();
        return this;
    }
#endif

    public bool GetTable<T>(out List<T> list) where T : DataItem, new()
    {
        list = null;
        if (connection == null)
            return false;
        connection.CreateTable<T>();
        list = connection.Table<T>().ToList();
        return true;
    }

    public int Remove<T>(int id) => connection.Delete<T>(id);

    public bool Update(object item)
    {
        connection.Update(item);
        return true;
    }

    public bool Insert(object item)
    {
        if (connection == null)
            return false;
        connection.Insert(item);
        return true;
    }
}