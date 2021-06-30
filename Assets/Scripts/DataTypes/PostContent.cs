// Author: wuchenyang(shpkng@gmail.com)

public enum PostContentType
{
    Text,
    Audio,
    Image,
    Video,
    Contact,
    Address,
}

public struct PostContent : IDatum
{
    public PostContentType type;
    public object content;
    private uint _id;

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