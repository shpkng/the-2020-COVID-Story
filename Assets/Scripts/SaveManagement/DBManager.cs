// Author: wuchenyang(shpkng@gmail.com) 

using System.IO;
using UnityEngine;

public class DBManager
{

    // private static UltraLiteDatabase database = null;
    private static DBManager _instance;

    public static DBManager instance
    {
        get
        {
            return _instance ??= new DBManager();
        }
    }

    // public static void LoadDefault()
    // {
    //     var resource = new UltraLiteDatabase(Path.Combine(Application.streamingAssetsPath,"db.db"));
    //     var col = resource.GetCollection("test");
    //     var bson = new BsonDocument();
    //     bson["name"] = "gay";
    //     for (int i = 0; i < 5000; i++)
    //     {
    //         bson[i.ToString()] = i;
    //     }
    //     col.Upsert(bson);
    //     resource.Dispose();
    //     resource.Shrink();
    // }
}