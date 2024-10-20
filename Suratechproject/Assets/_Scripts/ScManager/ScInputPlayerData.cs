using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScInputPlayerData : MonoBehaviour
{
    [SerializeField] Button saveButton;
    public TMP_InputField infName;
    public TMP_InputField infAge;
    public TMP_InputField infCenter;
    public TMP_InputField infTeacher;
    // Start is called before the first frame update
    void Start()
    {
        ValidateData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoSaveData()
    {
        int playerAvater = GameDataService.Instance.myPlayer.playerAvatar;
        GameDataService.Instance.ClearPlayerData();
        GameDataService.Instance.myPlayer.playerName = infName.text;
        GameDataService.Instance.myPlayer.playerAge = ToInt32OrDefault( infAge.text);
        GameDataService.Instance.myPlayer.playerCenter = infCenter.text;
        GameDataService.Instance.myPlayer.playerTeacher = infTeacher.text;
        GameDataService.Instance.myPlayer.currentQuestion = 1;
        GameDataService.Instance.myPlayer.playerAvatar = playerAvater;
        SceneMan.GoToNextScenceByIndex();
    }

    public int ToInt32OrDefault(string value, int defaultValue = 0)
    {
        int result;
        return int.TryParse(value, out result) ? result : defaultValue;
    }

    public void ValidateData()
    {
        if (infName.text.Length > 0
            && infAge.text.Length > 0
            && infCenter.text.Length > 0
            && infTeacher.text.Length > 0
            )
        {
            saveButton.gameObject.SetActive(true);
        }
        else
        {
            saveButton.gameObject.SetActive(false);
        }
    }
}
