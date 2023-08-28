using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnNextScene : MonoBehaviour
{
    public enum NextSceneType { Worldmap,Answer};
    public NextSceneType myType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoNextScene()
    {
        Debug.Log("DoNextScene");
        if (myType == NextSceneType.Worldmap)
        {
            SceneMan.GoToQuestion(GameDataService.Instance.myPlayer.currentQuestion);
        }
        else if (myType == NextSceneType.Answer)
        {
            Debug.Log(GameDataService.Instance.myPlayer.currentQuestion);
            GameDataService.Instance.myPlayer.currentQuestion++;
            SceneMan.GoToWorldMap();

        }
    }
}
