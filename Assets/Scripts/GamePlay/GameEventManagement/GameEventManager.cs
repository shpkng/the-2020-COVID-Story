// Author: wuchenyang(shpkng@gmail.com)

using System.Collections.Generic;

public class GameEventManager
{
    private static GameEventManager _instance;

    public static GameEventManager instance => _instance ??= new GameEventManager();

    public ICollection<WorldEvent> eventCache => new List<WorldEvent>();

    public bool UpdateCondition()
    {
        return true;
    }
}