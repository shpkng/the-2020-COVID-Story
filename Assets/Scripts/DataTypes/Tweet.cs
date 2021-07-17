// Author: wuchenyang(shpkng@gmail.com)

using System;
using Newtonsoft.Json;
using SQLite;

[Flags]
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
    [Column("type")] public int types { get; set; }
    private int[] contentIds;

    [Column("content_id")]
    public string contentIdStr
    {
        get => JsonConvert.SerializeObject(contentIds);
        set => JsonConvert.DeserializeObject<int[]>(value);
    }

    [Column("sender_id")] public int sender { get; set; }
    [Column("show_sender_id")] public bool showSenderId { get; set; }
    [Column("device")] public string device { get; set; }
    [Column("show_device")] public bool showDevice { get; set; }

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