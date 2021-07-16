// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;
using FF.Utils;
using System.Linq;

public interface IInitable
{
    void Init();
    void Release();
}

public class RuntimeDataContainer<T> : Singleton<RuntimeDataContainer<T>>, IInitable where T : DataItem
{
    Dictionary<int, T> cache;

    public virtual void Init()
    {

    }

    public virtual void Release()
    {

    }

    public void _Set(List<T> dataList = null)
    {
        if (dataList == null)
        {
            cache = null;
            return;
        }
        cache = dataList.ToDictionary(p => p.id);
    }

    public bool _Add(T data)
    {
        if (cache.ContainsKey(data.id))
        {
            return false;
        }
        cache.Add(data.id, data);
        return true;
    }

    public T _Get(int id)
    {
        if (cache.ContainsKey(id))
            return null;
        return cache[id];
    }

    public void _Remove(int id)
    {
        cache.Remove(id);
    }

    public void _Update(int id, T data)
    {
        if (cache.ContainsKey(id))
            cache[id] = data;
        else
            cache.Add(id, data);
    }

    public static void Set(List<T> dataList = null) => Instance._Set(dataList);

    public static bool Add(T data) => Instance._Add(data);

    public static T Get(int id) => Instance._Get(id);

    public static void Remove(int id) => Instance._Remove(id);

    public static void Update(int id, T data) => Instance._Update(id, data);
}