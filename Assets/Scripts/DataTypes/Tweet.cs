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
    public int[] contentIds;

    [Column("content_id")]
    public string contentIdStr
    {
        get => JsonConvert.SerializeObject(contentIds);
        set => contentIds = JsonConvert.DeserializeObject<int[]>(value);
    }

    public int[] commentIds;

    [Column("comment_id")]
    public string commentIdStr
    {
        get => JsonConvert.SerializeObject(commentIds);
        set => commentIds = JsonConvert.DeserializeObject<int[]>(value);
    }

    public int[] retweetIds;

    [Column("retweet_id")]
    public string retweetIdStr
    {
        get => JsonConvert.SerializeObject(retweetIds);
        set => retweetIds = JsonConvert.DeserializeObject<int[]>(value);
    }

    public int[] likes;

    [Column("likes_id")]
    public string likeStr
    {
        get => JsonConvert.SerializeObject(likes);
        set => likes = JsonConvert.DeserializeObject<int[]>(value);
    }

    [Column("sender_id")] public int sender { get; set; }
    [Column("show_sender_id")] public bool showSenderId { get; set; }
    [Column("device")] public string device { get; set; }
    [Column("show_device")] public bool showDevice { get; set; }
}