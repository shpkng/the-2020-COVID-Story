// Author: wuchenyang(shpkng@gmail.com)
public interface IMessage
{
    uint id { get;  }
    Content[] contents { get; }
}

public struct Message:IMessage
{
    public Content[] _contents;
    public uint id { get; }
    public Content[] contents { get; }
}

public struct ReplyMessage : IMessage
{
    public Content[] _contents;
    public uint id { get; }
    public Content[] contents { get; }
}