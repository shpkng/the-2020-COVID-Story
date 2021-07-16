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