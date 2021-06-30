// Author: wuchenyang(shpkng@gmail.com)

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

public struct EventDependency:IDatum
{
    public uint conditionId;
    public uint id { get; }
    public void Read()
    {
        throw new System.NotImplementedException();
    }

    public void Write()
    {
        throw new System.NotImplementedException();
    }

    public void Merge(bool @override)
    {
        throw new System.NotImplementedException();
    }
}