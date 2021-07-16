// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;
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
        // 初始化游戏数据
        DBManager.Instance.Init(DBManager.defaultDataPath);
        DataCacheManager.Instance.Init();
        DBManager.Instance.CreateTable<Conversation>().Insert(new Conversation
        {
            id = 234,
            messageIds = new List<int>() {8, 9, 6, 4},
        });
        DBManager.Instance.Release();
    }
}