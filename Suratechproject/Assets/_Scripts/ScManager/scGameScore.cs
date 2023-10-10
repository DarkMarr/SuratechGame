using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scGameScore : MonoBehaviour
{
    public TMP_Text txtPlayerData;
    public TMP_Text txtMoneyData;
    public TMP_Text txtWorkData;
    public TMP_Text txtHornorData;
    public TMP_Text txtRelationshipData;
    [SerializeField] Slider sidMoney;
    [SerializeField] Slider sidWork;
    [SerializeField] Slider sidHonor;
    [SerializeField] Slider sidRelation;

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
        txtMoneyData.text = string.Format("{0}",Mathf.RoundToInt( player.money));
        txtWorkData.text = string.Format("{0}", Mathf.RoundToInt(player.work));
        txtHornorData.text = string.Format("{0}", Mathf.RoundToInt(player.honor));
        txtRelationshipData.text = string.Format("{0}", Mathf.RoundToInt(player.relationship));
        sidMoney.value = player.money;
        sidWork.value = player.work;
        sidHonor.value = player.honor;
        sidRelation.value = player.relationship;
    }
}
