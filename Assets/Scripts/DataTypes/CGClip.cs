// Author: wuchenyang(shpkng@gmail.com)

using SQLite;

[Table("CGClip")]
public class CGClip : DataItem
{
    [Column("path")] public string path { get; set; }
    
}