using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

// 用來控制Chatbox的儲存

[CreateAssetMenu(fileName = "ChatboxManager", menuName = "Chatbox/ChatboxManager")]
public class ChatboxManager : ScriptableObject
{
    /// <summary>
    /// public List<列表型態> 列表名稱
    /// 列表裡, "List<>"內的資料型態 必須和 "想要指定的.cs檔案" 一致
    /// ex:
    /// public List<Chatbox> itemList = new List<Chatbox>();
    /// </summary>
    public List<Chatbox> itemList = new List<Chatbox>();
}