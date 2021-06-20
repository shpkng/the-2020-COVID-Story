// Author: wuchenyang(shpkng@gmail.com)

using System;
using UnityEngine;

    public class GameLauncher : MonoBehaviour
    {
        private void Awake()
        {
           var res =  SaveManager.ResetLocal();
           if (!res)
           {
               Debug.LogError("WTF");
           }
        }
    }