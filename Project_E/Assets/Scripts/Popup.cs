using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;

    public void SetContent(string title, string content) // public을 사용해 전역으로 선언
    {
        titleText.text = title;
        contentText.text = content;
    }


    public void ClosePopup()
    {
        Destroy(gameObject);
    }
}