// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;

public class EventManager
{
    private static EventManager _instance;

    public static EventManager instance => _instance ??= new EventManager();

    public ICollection<Event> eventCache => new List<Event>();

    public bool UpdateCondition()
    {
        
        return true;
    }
}