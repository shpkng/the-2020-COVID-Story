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
    public string favJson { get; set; }
    private Dictionary<int, byte> favourability;
    
    public string name { get; set; }
    public string userName { get; set; }
    public int age { get; set; }
    public int gender { get; set; }
    public int nationality { get; set; }
    public int occupation { get; set; }
    public int prevOccupation { get; set; }

    public override void Read()
    {
    }

    public override void Write()
    {
        throw new System.NotImplementedException();
    }

    public override void Merge(bool @override)
    {
        throw new System.NotImplementedException();
    }
}