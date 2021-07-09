// Author: wuchenyang(shpkng@gmail.com)

using System;
using UnityEngine;

public abstract class MessageBase : DataItem
{
    Tweet[] contents { get; }
}

[Serializable]
public class Message : MessageBase
{
    public Tweet[] _contents;

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
    public Tweet[] _contents;

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