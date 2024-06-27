using System;
using FrameWork;
using UnityEngine;

namespace GameFramework
{
    public class TestConfigComponent : MonoBehaviour
    {
        private void Start()
        {
            string path = "Assets/Scripts/ThirdParty/GameFramework/Configs/DefaultConfig.txt";
            GameEntry.Config.ReadData(path, this);
            var id = GameEntry.Config.GetInt("Scene.Main");
            Debug.LogError($"id = {id}");
        }
    }
}