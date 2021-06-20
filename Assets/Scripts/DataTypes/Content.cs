// Author: wuchenyang(shpkng@gmail.com)

public enum ContentType
{
    Text,
    Audio,
    Image,
    Video,
    Contact,
    Address,
}

public struct Content
{
    public ContentType type;
    public object content;
}