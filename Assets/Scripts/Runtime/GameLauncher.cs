// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

// 游戏的入口
public class GameLauncher : MonoBehaviour
{
    private void Awake()
    {
        Init();
    }

    // 初始化游戏
    private static void Init()
    {
        //// 初始化游戏数据
        DBManager.Instance.Init(DBManager.defaultDataPath);
        DataCacheManager.Init();
        DBManager.Instance.CreateTable<Tweet>().Insert(new Tweet
        {
            contentIdStr = JsonConvert.SerializeObject(new int[] {1, 2, 3, 4, 5}),
            showDevice = false
        });
        DBManager.Instance.Release();

        // DataCacheManager.Init()
        //     .LoadTables();
    }
}