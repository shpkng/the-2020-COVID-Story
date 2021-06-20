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
    Other
}

public enum Occupation
{
    
}

public struct User
{
    public uint id;
    public string name;
    public string userName;
    public uint age;
    public Gender gender;
    public Nationality nationality;
    public Occupation occupation;
    public Occupation prevOccupation;
}