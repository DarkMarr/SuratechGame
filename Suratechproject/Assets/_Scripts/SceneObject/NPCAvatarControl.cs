using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAvatarControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EasyShow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[] npcAvatarObject;

    void EasyShow()
    {
        int avartarId = GameDataService.Instance.myPlayer.playerAvatar;
        for (int i = 0; i < npcAvatarObject.Length; i++)
        {
            bool active = (i == avartarId);
            npcAvatarObject[i].SetActive(active);
        }
    }

}
