using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 用來控制Chatbox的生成

public class ChatboxGenerator : MonoBehaviour
{
    public Chatbox Chatbox;
    public Transform Parent;

    #region singleton
    // 可以在其他代碼進行訪問
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
        // 確保 Chatbox 已經被實例化
        if (Chatbox == null)
        {
            // 實例化 Chatbox
            Chatbox = ScriptableObject.CreateInstance<Chatbox>();
        }
    }

    public void 產生對話框()
    {
        /*
         *  // ArgumentException: Cannot instantiate a ScriptableObject with a position and rotation
         *  // + new Vector3(960f, 613.5f, 0f)
         */
        Instantiate(ChatboxModule, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
}