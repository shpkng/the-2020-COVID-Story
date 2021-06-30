// Author: wuchenyang(shpkng@gmail.com)

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

public struct User : IDatum
{
    public string name;
    public string userName;
    public uint age;
    public Gender gender;
    public Nationality nationality;
    public Occupation occupation;
    public Occupation prevOccupation;
    public uint id { get; }

    public void Read()
    {
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