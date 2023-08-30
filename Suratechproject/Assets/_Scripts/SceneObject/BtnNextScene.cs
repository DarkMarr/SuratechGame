using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnNextScene : MonoBehaviour
{
    int maxQuextion = 3;
    public enum NextSceneType { Worldmap,Answer,GameScore};
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
            if (GameDataService.Instance.myPlayer.currentQuestion <= maxQuextion)
            {
                SceneMan.GoToWorldMap();
            }
            else
            {
                SceneMan.GoToGameScore();
            }

        }
        else if (myType == NextSceneType.GameScore)
        {
            SceneMan.GoToTitle();
        }
    }
}
