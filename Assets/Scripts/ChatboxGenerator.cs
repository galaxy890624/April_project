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
    public GameObject ChatboxModule;

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

    public void ���͹�ܮ�()
    {
        /*
         *  // ArgumentException: Cannot instantiate a ScriptableObject with a position and rotation
         *  // + new Vector3(960f, 613.5f, 0f)
         */
        Instantiate(ChatboxModule, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
}