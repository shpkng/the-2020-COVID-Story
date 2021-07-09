// Author: wuchenyang(shpkng@gmail.com)

using System;
using SQLite;

enum EventDependencyType
{
    SawTwitter,
    PostTwitter,

    GetNewFriend,
    ApplyNewFriend,
    AcceptNewFriend,

    SawMessage,
    SendMessage,
}

[Table("WorldEventDependency")]
public class WorldEventDependency : DataItem
{
    public uint conditionId;

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