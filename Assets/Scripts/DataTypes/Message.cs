// Author: wuchenyang(shpkng@gmail.com)

using System;
using Newtonsoft.Json;
using SQLite;

public abstract class MessageBase : DataItem
{
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

}

[Serializable]
public class ReplyMessage : MessageBase
{

}