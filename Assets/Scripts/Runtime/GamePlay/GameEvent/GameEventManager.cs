using FF.Utils;
class GameEventManager : Singleton<GameEventManager>
{
    public void _UpdateDependency(int id, params object[] args)
    {
        var item = WorldEventDependencyContainer.Get(id);
        if (item == null)
            return;
        item.UpdateDependency(id, args);
    }
    public static void UpdateDependency(int id, params object[] args) => Instance._UpdateDependency(id, args);
}
