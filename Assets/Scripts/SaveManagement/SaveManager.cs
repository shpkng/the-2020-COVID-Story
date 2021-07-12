// Author: wuchenyang(shpkng@gmail.com)

using UnityEngine;
using System.IO;
using FF.Utils;

public class SaveManager : MonoSingleton<SaveManager>
{
    private const string defaultDataName = "default.db";
    private const string userDataName = "current.db";
    private const string userDataFolderName = "UserData";
    private static string _defaultDataPath;
    private static string _userDataFolderPath;
    private static string _userDataPath;

    private static string defaultDataPath =>
        _defaultDataPath ??= Path.Combine(Application.streamingAssetsPath, defaultDataName);

    private static string userDataFolderPath =>
        _userDataFolderPath ??= Path.Combine(Application.persistentDataPath, userDataFolderName);

    private static string userDataPath => _userDataPath ??= Path.Combine(Application.persistentDataPath, userDataName);

    private static bool defaultDataExists => File.Exists(defaultDataPath);

    private static bool userDataExisting => File.Exists(userDataPath);


    private static bool ResetLocal()
    {
        return false;
    }

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

    public static void Init()
    {
        DBManager.Instance.Init(defaultDataPath);
    }
}