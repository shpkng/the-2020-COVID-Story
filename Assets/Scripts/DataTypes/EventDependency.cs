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

public struct EventDependency
{
    public uint id;
    public uint conditionId;
}