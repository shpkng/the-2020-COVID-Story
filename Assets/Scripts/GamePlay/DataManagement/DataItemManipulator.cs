// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;

public class DataItemManipulator<T> where T : DataItem
{
    Dictionary<int, T> cache = new Dictionary<int, T>();
}