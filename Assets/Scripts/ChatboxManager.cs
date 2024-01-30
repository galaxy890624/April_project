using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

// �Ψӱ���Chatbox���ͦ�

[CreateAssetMenu(fileName = "ChatboxManager", menuName = "Chatbox/ChatboxManager")]
public class ChatboxManager : ScriptableObject
{
    /// <summary>
    /// public List<�C���A> �C��W��
    /// �C���, "List<>"������ƫ��A �����M "�Q�n���w��.cs�ɮ�" �@�P
    /// ex:
    /// public List<Chatbox> itemList = new List<Chatbox>();
    /// </summary>
    public List<Chatbox> itemList = new List<Chatbox>();
}
