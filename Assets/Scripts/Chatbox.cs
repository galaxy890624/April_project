using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 用來儲存對話框的訊息
// ex: 聊天對象的人物頭像, 對話框, ...
// 參考Item.cs

[CreateAssetMenu(fileName = "New Chatbox", menuName = "Chatbox/New Chatbox")] // 右鍵 > Chatbox > New Chatbox
public class Chatbox : ScriptableObject
{
    public Sprite HeadImage; // 頭像圖片
    public Sprite ChatboxImage; // 對話框圖片
    [TextArea] // 可以輸入多行內容, 而不再僅限於1行
    public string Info; // 測試文字(ex: 時間)
}
