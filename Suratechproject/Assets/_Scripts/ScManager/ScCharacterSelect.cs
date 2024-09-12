using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScCharacterSelect : MonoBehaviour
{
    [SerializeField] bool isSelectAvater = false;
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
        Debug.LogFormat("DoChoose {0}",avatar);
        GameDataService.Instance.myPlayer.playerAvatar = avatar;
        SceneMan.GoToInputPlayerData();
    }
    public int myAvartarId;
    private void OnMouseDown()
    {
        if (isSelectAvater)
        {
            Debug.LogFormat("ScCharacterSelect >> OnMouseDown ");
            GameDataService.Instance.myPlayer.playerAvatar = myAvartarId;
            SceneMan.GoToInputPlayerData();
        }
    }


}

