// Author: wuchenyang(shpkng@gmail.com)

using System;
using SQLite;
using UnityEngine;

[Serializable]
public abstract class DataItem
{
    [PrimaryKey, AutoIncrement, NotNull, Unique]
    public int id { get; set; }

    [Column("time")] public DateTime time { get; set; }

    public abstract void Read();
    public abstract void Write();
    public abstract void Merge(bool @override);
}