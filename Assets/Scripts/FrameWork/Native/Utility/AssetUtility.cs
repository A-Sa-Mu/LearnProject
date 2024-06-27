using GameFramework;
using GameFramework.Resource;
using System;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace FrameWork
{
    public static class AssetUtility
    {
        public static string GetDataTableAsset(string assetName,bool isBinary)
        {
            if (isBinary)
            {
                return $"Assets/AssetBundleRes/Configs/DataTables/{assetName}.bytes";
            }
            else
            {
                return $"Assets/AssetBundleRes/Configs/DataTables/{assetName}.txt";
            }
        }
    }
}