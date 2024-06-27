using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityGameFramework.Runtime;
using AssetUtility = FrameWork.AssetUtility;
using GameEntry = FrameWork.GameEntry;

namespace GameFramework
{
    public class TestDataTableComponent : MonoBehaviour
    {
        private DataTableComponent DataTable;
        private string[] DataTableNames;

        private void Start()
        {
            DataTable = GameEntry.DataTable;
            DataTableNames = new string[] { "Music" };
            foreach (var tableName in DataTableNames)   // 加载表格
            {
                var dataTableAssetName = AssetUtility.GetDataTableAsset(tableName, false);
                GameEntry.DataTable.LoadDataTable(tableName, dataTableAssetName, this);
            }
            
            // 查询
            var music = GameEntry.DataTable.GetDataTable<DRMusic>();
            Debug.LogError(music.GetDataRow(1).Id);    // 第一行

            var music2 = music.GetDataRow(x => x.Id == 1);  // 根据id查询
            Debug.LogError($"{music2.AssetName}");
        }
    }
}