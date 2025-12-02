using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab;
    public Transform canvasTransform;
    public string TitleText;
    public string ContentText;

    public void OpenNoticePopup()
    {                                               // Instantiate는 해당 좌표에 인스턴스로 생성을 한다.
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform);    // 생성한 팝업 변수, GameObject 값으로 반환 따라서 변수 선언시 GameObject로 선언
        Popup popupScript = newPopup.GetComponent<Popup>();                 // 팝업 스크립트 변수
                                                                            // newPopup은 위에 선언한 변수 명, 

        popupScript.SetContent(this.TitleText, this.ContentText);           // 팝업 내용 설정
    }
}