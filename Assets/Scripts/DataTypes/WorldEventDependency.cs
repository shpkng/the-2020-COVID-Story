// Author: wuchenyang(shpkng@gmail.com)

using SQLite;

enum EventDependencyType
{
    ReadTwitter,
    PostTwitter,

    GetNewFriend,
    ApplyNewFriend,
    AcceptNewFriend,

    ReadMessage,
    SendMessage,
}

[Table("WorldEventDependency")]
public class WorldEventDependency : DataItem
{
    [Column("condition_id")] public int conditionId { get; set; }
    [Column("")] public float marker { get; set; }

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