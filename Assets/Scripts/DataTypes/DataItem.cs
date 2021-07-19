// Author: wuchenyang(shpkng@gmail.com)

using System;
using SQLite;

[Serializable]
public abstract class DataItem
{
    [PrimaryKey, AutoIncrement, NotNull, Unique]
    public int id { get; set; }

    public DateTime time;

    [Column("time")]
    private long timestamp
    {
        get => time.ToFileTimeUtc();
        set => time = DateTime.FromFileTimeUtc(value);
    }

}