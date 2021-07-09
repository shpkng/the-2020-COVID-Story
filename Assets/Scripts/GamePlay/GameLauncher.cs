// Author: wuchenyang(shpkng@gmail.com)

using UnityEngine;

public class GameLauncher : MonoBehaviour
{
    private void Awake()
    {
        SaveManager.Init();
    }
}