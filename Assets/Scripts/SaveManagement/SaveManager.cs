// Author: wuchenyang(shpkng@gmail.com)

using System;
using System.Collections;
using System.Collections.Generic;
using FF.Utils;

/// <summary>
/// 数据库中读取数据后存在当前类
/// </summary>
public class CacheManager : Singleton<CacheManager>
{
    private Dictionary<Type, object> tables;

    public void Init()
    {
        Clear();
        tables = new Dictionary<Type, object>();
        LoadTables();
        RegisterEvents();
    }

    private void RegisterEvents()
    {
    }

    public void LoadTables()
    {
        if (DBManager.Instance.GetTable(out List<Message> messages))
            tables.Add(typeof(Message), messages);
        if (DBManager.Instance.GetTable(out List<Person> persons))
            tables.Add(typeof(Person), persons);
        if (DBManager.Instance.GetTable(out List<Conversation> conversations))
            tables.Add(typeof(Conversation), conversations);
        if (DBManager.Instance.GetTable(out List<Tweet> tweets))
            tables.Add(typeof(Tweet), tweets);
        if (DBManager.Instance.GetTable(out List<WorldEvent> events))
            tables.Add(typeof(WorldEvent), events);
        if (DBManager.Instance.GetTable(out List<WorldEventDependency> eventDependencies))
            tables.Add(typeof(WorldEventDependency), eventDependencies);
    }

    public void SaveTables()
    {
    }

    public void Clear()
    {
        tables?.Clear();
        tables = null;
    }
}