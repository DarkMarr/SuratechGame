using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarControl : MonoBehaviour
{
    public GameObject[] avatar;
    public GameObject[] avatar2;
    public bool isBig = false;
    //public GameObject[] mainPlayer;

    //public GameObject[] heads;
    //public GameObject[] lLeg;
    //public GameObject[] rLeg;
    //public GameObject[] lShoulder;
    //public GameObject[] rShoulder;
    //public GameObject[] lArm;
    //public GameObject[] rArm;
    //public GameObject[] body;
    // Start is called before the first frame update
    void Start()
    {
        EasyShow();
        //ShowAvartar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EasyShow()
    {
        int avartarId = GameDataService.Instance.myPlayer.playerAvatar;
        for(int i=0;i< avatar.Length;i++)
        {
            if (isBig == false)
            {
                bool active = (i == avartarId);
                avatar[i].SetActive(active);
            }
            else
            {
                avatar[i].SetActive(false);
            }
        }

        for (int i = 0; i < avatar2.Length; i++)
        {
            if (isBig == true)
            {
                bool active = (i == avartarId);
                avatar2[i].SetActive(active);
            }
            else
            {
                avatar2[i].SetActive(false);
            }
        }

    }
    //public void ShowAvartar()
    //{
    //    int avartarId = GameDataService.Instance.myPlayer.playerAvatar;
    //    for(int i=0;i<heads.Length;i++)
    //    {
    //        bool isAvatar = (i == avartarId);
    //        heads[i].SetActive(isAvatar);
    //        lLeg[i].SetActive(isAvatar);
    //        rLeg[i].SetActive(isAvatar);
    //        lShoulder[i].SetActive(isAvatar);
    //        rShoulder[i].SetActive(isAvatar);
    //        lArm[i].SetActive(isAvatar);
    //        rArm[i].SetActive(isAvatar);
    //        body[i].SetActive(isAvatar);
    //    }

    //}



}
