sealed class WorldEventDependencyContainer : RuntimeDataContainer<WorldEventDependency>
{
    public void _TriggerDependency(int id, params object[] args)
    {
        var item = _Get(id);
        if (item == null)
            return;
        item.Trigger(id, args);
    }
    public static void TriggerDependency(int id, params object[] args) => (Instance as WorldEventDependencyContainer)._TriggerDependency(id, args);
}
