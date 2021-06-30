// Author: wuchenyang(shpkng@gmail.com)

public class SaveManager
{
    private static SaveManager _instance;
    private static SaveManager instance => _instance ??= new SaveManager();

    private bool _ResetLocal()
    {
        return false;
    }

    private bool _SaveLocal()
    {
        return false;
    }

    public static bool ResetLocal()
    {
        DBManager.LoadDefault();
        return instance._ResetLocal();
    }

    public static bool SaveLocal()
    {
        return instance._SaveLocal();
    }
}