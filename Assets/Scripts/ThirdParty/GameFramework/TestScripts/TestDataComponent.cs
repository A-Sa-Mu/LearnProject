using System;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameEntry = FrameWork.GameEntry;

namespace GameFramework
{
    public class TestDataComponent : MonoBehaviour
    {
        private void Start()
        {
            var component = UnityGameFramework.Runtime.GameEntry.GetComponent<DataNodeComponent>();

            // 设置不同类型的节点数据
            component.SetData("Player.Id", (VarInt32)10101);
            component.SetData("Player.Name", (VarString)"frank");
            component.SetData("Player.Sex", (VarBoolean)true);
            component.SetData("Player.Age", (VarInt32)30);

            // 获取节点上数据
            string name = component.GetData<VarString>("Player.Name");
            Debug.Log("获取节点上数据：" + name);

            // 根据父节点获取孩子数据
            var parent = component.GetNode("Player");
            var age = parent.GetChild("Age").GetData();
            Debug.Log("根据父节点获取孩子数据：" + age);

            // 判断节点是否存在
            var node = component.GetNode("Player.Age");
            if (node != null)
            {
                Debug.Log("节点：存在");
            }
            else
            {
                Debug.Log("节点：不存在");
            }

            // 移除节点
            component.RemoveNode("Player.Age");

            var del_node = component.GetNode("Player.Age");
            if (del_node != null)
            {
                Debug.Log("节点：存在");
            }
            else
            {
                Debug.Log("节点：不存在");
            }
        }
    }
}
