using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnNextScene : MonoBehaviour
{
    int maxQuestion = 20;
    public enum NextSceneType { Worldmap,Answer,GameScore,GraphSummary,Intro,SelectTarget,Outro};
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
            int qustion = GameDataService.Instance.questionList[GameDataService.Instance.myPlayer.currentIndexQuestion];
            Debug.LogFormat("currentQuestion = {0},currentIndexQuestion = {1} , qustion = {2}",
                GameDataService.Instance.myPlayer.currentQuestion,
                GameDataService.Instance.myPlayer.currentIndexQuestion,
                qustion);
            SceneMan.GoToQuestion(qustion);
        }
        else if (myType == NextSceneType.Answer)
        {
            int qustion = GameDataService.Instance.questionList[GameDataService.Instance.myPlayer.currentIndexQuestion];
            Debug.Log("DoNextScene >> Answer");
            Debug.LogFormat("currentQuestion = {0},currentIndexQuestion = {1} , qustion = {2}",
                GameDataService.Instance.myPlayer.currentQuestion,
                GameDataService.Instance.myPlayer.currentIndexQuestion,
                qustion);
            GameDataService.Instance.myPlayer.currentIndexQuestion++;
            SceneMan.GoToGameScore();
        }
        else if (myType == NextSceneType.GameScore)
        {
            if (GameDataService.Instance.myPlayer.currentIndexQuestion <= maxQuestion)
            {
                SceneMan.GoToWorldMap();
            }
            else
            {
                SceneMan.GoToGraphSummary();
            }
        }
        else if (myType == NextSceneType.GraphSummary)
        {
            SceneMan.GoToOutro();
        }
        else if (myType == NextSceneType.Outro)
        {
            SceneMan.GoToTitle();
        }
        else if (myType == NextSceneType.Intro)
        {
            SceneMan.GoToCharacterSelect();
        }
        else if (myType == NextSceneType.SelectTarget)
        {
            SceneMan.GoToWorldMap();
        }
    }
}
