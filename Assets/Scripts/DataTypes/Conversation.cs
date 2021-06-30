// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;

public struct Conversation:IDatum
{
    public uint id { get; }
    private List<Message> _messages;

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