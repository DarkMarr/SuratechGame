using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scGameScore : MonoBehaviour
{
    public TMP_Text txtPlayerData;
    public TMP_Text txtMoneyData;
    public TMP_Text txtWorkData;
    public TMP_Text txtHornorData;
    public TMP_Text txtRelationshipData;

    // Start is called before the first frame update
    void Start()
    {
        BindData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BindData()
    {
        PlayerVO player = GameDataService.Instance.myPlayer;
        txtPlayerData.text = string.Format("{0} อายุ {1} ปี", player.playerName, player.playerAge);
        txtMoneyData.text = string.Format("{0}", player.money);
        txtWorkData.text = string.Format("{0}", player.work);
        txtHornorData.text = string.Format("{0}", player.honor);
        txtRelationshipData.text = string.Format("{0}", player.relationship);
    }
}
