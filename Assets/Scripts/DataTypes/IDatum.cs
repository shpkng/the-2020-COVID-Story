// Author: wuchenyang(shpkng@gmail.com)

public interface IDatum
{
    uint id { get; }
    void Read();
    void Write();
    void Merge(bool @override);
}