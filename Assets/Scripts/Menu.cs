using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // [SerializeField] UnityEvent 按鈕點擊音效 = null;

    public void 開始()
    {
        Debug.Log("開始");
        SceneManager.LoadScene("GamePlay");
    }

    public void 讀取()
    {
        Debug.Log("讀取");
        //SceneManager.LoadScene("TechnologyTree");

    }
    public void 選項()
    {
        Debug.Log("選項");
    }
    public void 離開()
    {
        Debug.Log("離開");
    }
}
