using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScInputPlayerData : MonoBehaviour
{
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
        GameDataService.Instance.myPlayer.currentQuestion = 1;
        SceneMan.GoToWorldMap();
    }
}
