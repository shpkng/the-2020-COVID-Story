// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;
using SQLite;

public enum Gender
{
    Male,
    Female,
    Other
}

public enum Nationality
{
    China,
    US,
    Japan,
    Other
}

public enum Occupation
{
    Unknown,
}

[Table("Person")]
public class Person : DataItem
{
    [Column("fav_json")] public string favJson { get; set; }
    private Dictionary<int, byte> favourability;

    [Column("name")] public string name { get; set; }
    [Column("user_name")] public string userName { get; set; }
    [Column("age")] public int age { get; set; }

    [Column("gender")] public int gender { get; set; }
    [Column("nationality")] public int nationality { get; set; }
    [Column("occupation")] public int occupation { get; set; }
    [Column("prev_occupation")] public int prevOccupation { get; set; }


}