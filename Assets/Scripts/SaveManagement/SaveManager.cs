// Author: wuchenyang(shpkng@gmail.com)

using UnityEngine;
using System.IO;
using Directory = UnityEngine.Windows.Directory;

public class SaveManager
{
    private const string defaultDataName = "defualt.db";
    private const string userDataName = "current.db";
    private const string userDataFolderName = "UserData";
    private static string _defaultDataPath;
    private static string _userDataFolderPath;
    private static string _userDataPath;

    private static SaveManager _instance;
    private static SaveManager instance => _instance ??= new SaveManager();

    private static string defaultDataPath =>
        _defaultDataPath ??= Path.Combine(Application.streamingAssetsPath, defaultDataName);

    private static string userDataFolderPath =>
        _userDataFolderPath ??= Path.Combine(Application.persistentDataPath, userDataFolderName);

    private static string userDataPath => _userDataPath ??= Path.Combine(Application.persistentDataPath, userDataName);

    private static bool defaultDataExists => File.Exists(defaultDataPath);

    private static bool isUserDataExisting => File.Exists(userDataPath);


    private bool _ResetLocal()
    {
        return false;
    }

    private bool _SaveLocal()
    {
        return false;
    }

    public static bool ResetLocal()
    {
        DBManager.LoadDefault();
        return instance._ResetLocal();
    }

    public static bool SaveLocal()
    {
        return instance._SaveLocal();
    }

    public static bool CopyDefault(bool ignoreExisting = false)
    {
        if (!defaultDataExists)
        {
            Debug.LogError("Default data is not available!");
            return false;
        }

        if (!ignoreExisting && isUserDataExisting)
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
}