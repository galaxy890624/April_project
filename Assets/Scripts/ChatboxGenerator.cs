using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �Ψӱ���Chatbox���ͦ�

public class ChatboxGenerator : MonoBehaviour
{
    public Chatbox Chatbox;
    public Transform Parent;

    #region singleton
    // �i�H�b��L�N�X�i��X��
    static ChatboxGenerator instance;
    public ChatboxManager ChatboxManager;
    public Text ItemInfo;
    public GameObject ChatboxModule_0; // ��誺��ܮؼҲ�
    public GameObject ChatboxModule_1; // �ۤv����ܮؼҲ�

    //public List<GameObject> Slots = new List<GameObject>();

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }
    #endregion

    // initialize
    private void OnEnable()
    {
        // �T�O Chatbox �w�g�Q��Ҥ�
        if (Chatbox == null)
        {
            // ��Ҥ� Chatbox
            Chatbox = ScriptableObject.CreateInstance<Chatbox>();
        }
    }

    public void ���͹�ܮ�0()
    {
        // �O�o�bContent�[�WVertical Layout Group����, ��l����y����w��
        Instantiate(ChatboxModule_0, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
    public void ���͹�ܮ�1()
    {
        // �O�o�bContent�[�WVertical Layout Group����, ��l����y����w��
        Instantiate(ChatboxModule_1, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
}