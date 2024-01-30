using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 用來控制Chatbox的生成

public class ChatboxGenerator : MonoBehaviour
{
    Chatbox Chatbox;

    // initialize
    private void OnEnable()
    {
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }

    // Game logic
    // Update is called once per frame
    private void Update()
    {

    }
}
