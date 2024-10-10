using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnNextScenceByIndex : MonoBehaviour
{
    public enum NextSceneType { NextByIndex, GotoGraphSummary};
    public NextSceneType myType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScence()
    {
        if (myType == NextSceneType.NextByIndex)
        {
            SceneMan.GoToNextScenceByIndex();
        }
        else
        {
            SceneMan.GoToGraphSummary();
        }
    }
}
