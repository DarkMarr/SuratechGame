using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScWelcome : MonoBehaviour
{
    [SerializeField] TMP_Text m_Text1;
    [SerializeField] TMP_Text m_Text2;
    // Start is called before the first frame update
    void Start()
    {
        PrepareText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrepareText()
    {
        m_Text1.text = string.Format("สวัสดี! {0}", GameDataService.Instance.myPlayer.playerName);
        m_Text2.text = string.Format("ตอนนี้คุณคือ {0} {1} ในวัย 14 ปี", Prefix()
            , GameDataService.Instance.myPlayer.playerName);
    }

    string Prefix()
    {
        string result = "";
        switch (GameDataService.Instance.myPlayer.playerAvatar)
        {
            case 0:
                result = "เด็กชาย";
                break;
            case 1:
                result = "เด็กชาย";
                break;
            case 2:
                result = "เด็กหญิง";
                break;
            case 3:
                result = "เด็กหญิง";
                break;

        }
        return result;
    }
}
