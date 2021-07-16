// Author: wuchenyang(shpkng@gmail.com)

using System;
using Newtonsoft.Json;
using SQLite;

public abstract class MessageBase : DataItem
{
    public Tweet[] contents { get; private set; }
    public int[] contentIds;

    [Column("message_ids_str")]
    public string contentIdsStr
    {
        get => JsonConvert.SerializeObject(contentIds);
        set => contentIds = JsonConvert.DeserializeObject<int[]>(value);
    }
}

[Serializable]
public class Message : MessageBase
{
    public override void Read()
    {
        throw new System.NotImplementedException();
    }

    public override void Write()
    {
        throw new System.NotImplementedException();
    }

    public override void Merge(bool @override)
    {
        throw new System.NotImplementedException();
    }
}

[Serializable]
public class ReplyMessage : MessageBase
{
    public override void Read()
    {
        throw new System.NotImplementedException();
    }

    public override void Write()
    {
        throw new System.NotImplementedException();
    }

    public override void Merge(bool @override)
    {
        throw new System.NotImplementedException();
    }
}