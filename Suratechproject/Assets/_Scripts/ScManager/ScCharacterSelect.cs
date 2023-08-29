using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScCharacterSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoChoose(int avatar)
    {
        GameDataService.Instance.myPlayer.playerAvatar = avatar;
        SceneMan.GoToInputPlayerData();
    }
}

