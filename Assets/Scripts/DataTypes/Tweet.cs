// Author: wuchenyang(shpkng@gmail.com)

using SQLite;

public enum ContentType
{
    Text,
    Audio,
    Image,
    Video,
    Contact,
    Address,
}

[Table("Tweet")]
public class Tweet : DataItem
{
    [Column("type")]
    public ContentType type{get; set;}
    [Column("content_id")]
    public int contentId{get; set; }
    [Column("sender_id")]
    public int sender { get; set; }

    public override void Read()
    {
        throw new System.NotImplementedException();
    }

    public override void Write()
    {
        
    }

    public override void Merge(bool @override)
    {
        throw new System.NotImplementedException();
    }
}