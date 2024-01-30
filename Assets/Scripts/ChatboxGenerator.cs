using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 用來控制Chatbox的生成

public class ChatboxGenerator : MonoBehaviour
{
    public Chatbox chatbox; // 注意：我們將 Chatbox 更改為小寫，以避免與類型名稱混淆

    // initialize
    private void OnEnable()
    {
        // 確保 chatbox 已經被實例化
        if (chatbox == null)
        {
            // 實例化 chatbox
            chatbox = ScriptableObject.CreateInstance<Chatbox>();
        }

        // print($"<color=#ff00ff>Info:<color=#00ff00>{chatbox.Info}</color></color>");
    }

    // Game logic
    // Update is called once per frame
    private void Update()
    {

    }

    public void 產生對話框()
    {
        // 使用 chatbox 來實例化對話框，你需要根據 Chatbox 類別的實際內容進行調整
        Instantiate(chatbox);
        print($"<color=#ff00ff>Info:<color=#00ff00>{chatbox.Info}</color></color>");
    }
}