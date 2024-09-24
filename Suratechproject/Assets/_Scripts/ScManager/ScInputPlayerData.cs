using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScInputPlayerData : MonoBehaviour
{
    public TMP_InputField infName;
    public TMP_InputField infAge;
    public TMP_InputField infCenter;
    public TMP_InputField infTeacher;
    // Start is called before the first frame update
    void Start()
    {
        
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
        SceneMan.GoToWorldMap();
    }

    public int ToInt32OrDefault(string value, int defaultValue = 0)
    {
        int result;
        return int.TryParse(value, out result) ? result : defaultValue;
    }
}
