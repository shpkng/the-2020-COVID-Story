// Author: wuchenyang(shpkng@gmail.com)

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;
using UnityEngine;

[Serializable]
[Table("Conversation")]
public class Conversation : DataItem
{
    public List<int> messageIds;

    [Column("message_ids")]
    public string messageIdsJson
    {
        get => JsonConvert.SerializeObject(messageIds);
        set => JsonConvert.DeserializeObject<List<int>>(value);
    }

}