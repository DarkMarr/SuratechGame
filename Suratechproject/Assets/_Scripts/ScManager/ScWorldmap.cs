using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScWorldmap : MonoBehaviour
{
    public WaypointManager waypointManager;
    // Start is called before the first frame update
    void Start()
    {
        int waypointIndex = GameDataService.Instance.myPlayer.currentIndexQuestion ;
        waypointManager.SetStartWaypoint(waypointIndex);
        waypointManager.StartMove();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScence()
    {

    }
}
