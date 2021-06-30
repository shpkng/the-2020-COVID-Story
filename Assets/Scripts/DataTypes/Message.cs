// Author: wuchenyang(shpkng@gmail.com)
public interface IMessage :IDatum
{
    PostContent[] contents { get; }
}

public struct Message:IMessage
{
    public PostContent[] _contents;
    public uint id { get; }
    public PostContent[] contents { get; }
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

public struct ReplyMessage : IMessage
{
    public PostContent[] _contents;
    public uint id { get; }
    public PostContent[] contents { get; }
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