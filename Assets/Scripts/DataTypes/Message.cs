// Author: wuchenyang(shpkng@gmail.com)

using System;
using SQLite;

public abstract class MessageBase : DataItem
{
    public Tweet[] contents { get; private set; }
    [Column("message_ids")] public int[] contetnIds { get; set; }
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