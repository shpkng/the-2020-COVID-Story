// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;
using FF.Utils;

/// <summary>
/// 数据库中读取数据后通过这个类存储到各自的Container
/// </summary>
public class DataCacheManager : Singleton<DataCacheManager>
{
    private HashSet<IInitable> containers;
    public void Init()
    {
        containers = new HashSet<IInitable>
        {
            MessageContainer.Instance,
            ReplyMessageContainer.Instance,
            PersonContainer.Instance,
            ConversationContainer.Instance,
            TweetContainer.Instance,
            WorldEventContainer.Instance,
            WorldEventDependencyContainer.Instance,
            TweetContainer.Instance,
        };
        foreach (var item in containers)
        {
            item.Init();
        }
        LoadTables();
    }

    public void LoadTables()
    {
        if (DBManager.Instance.GetTable(out List<Message> messages))
        {
            MessageContainer.Set(messages);
        }
        if (DBManager.Instance.GetTable(out List<Person> persons))
        {
            PersonContainer.Set(persons);
        }
        if (DBManager.Instance.GetTable(out List<Conversation> conversations))
        {
            ConversationContainer.Set(conversations);
        }
        if (DBManager.Instance.GetTable(out List<Tweet> tweets))
        {
            TweetContainer.Set(tweets);
        }
        if (DBManager.Instance.GetTable(out List<WorldEvent> events))
        {
            WorldEventContainer.Set(events);
        }
        if (DBManager.Instance.GetTable(out List<WorldEventDependency> eventDependencies))
        {
            WorldEventDependencyContainer.Set(eventDependencies);
        }
        DBManager.Instance.Release();
    }

    public void SaveTables()
    {
    }

    public void Clear()
    {
        foreach (var container in containers)
        {
            container.Release();
        }
    }
}