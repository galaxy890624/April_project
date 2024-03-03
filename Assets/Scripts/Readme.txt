https://youtu.be/RagAaYn9Qks

Item.cs : 道具名字, 道具圖片, 持有量, 提示訊息, ...
Inventory.cs : 背包系統(My Bag), 使用List來儲存道具, ex: sword, shoes

public List<Item> itemList = new List<Item> // public List<列表型態> 列表名稱


也可以用以下這種寫法:
https://youtu.be/0nW5PhQTWbQ?si=26DxQwv-RiyFSVqN&t=589


***以下為April_project內的c#程式說明***
Chatbox.cs
// 用來儲存對話框的訊息
// ex: 聊天對象的人物頭像, 對話框, ...

ChatboxManager.cs
// 用來控制Chatbox的儲存

ChatboxGenerator.cs
// 用來控制Chatbox的生成

**********20240303100300**********
新建一個Scroll View(生成是正常的)