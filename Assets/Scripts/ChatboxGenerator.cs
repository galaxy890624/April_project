using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ψӱ���Chatbox���ͦ�

public class ChatboxGenerator : MonoBehaviour
{
    public Chatbox chatbox; // �`�N�G�ڭ̱N Chatbox ��אּ�p�g�A�H�קK�P�����W�ٲV�c

    // initialize
    private void OnEnable()
    {
        // �T�O chatbox �w�g�Q��Ҥ�
        if (chatbox == null)
        {
            // ��Ҥ� chatbox
            chatbox = ScriptableObject.CreateInstance<Chatbox>();
        }

        print($"<color=#ff00ff>Info:<color=#00ff00>{chatbox.Info}</color></color>");
    }

    // Game logic
    // Update is called once per frame
    private void Update()
    {

    }

    public void ���͹�ܮ�()
    {
        // �ϥ� chatbox �ӹ�Ҥƹ�ܮءA�A�ݭn�ھ� Chatbox ���O����ڤ��e�i��վ�
        Instantiate(chatbox);
    }
}