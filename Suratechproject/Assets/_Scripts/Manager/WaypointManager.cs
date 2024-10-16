using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class WaypointManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] waypoints;
    [SerializeField]
    GameObject player;
    [SerializeField]
    Color passColor = Color.red;
    [SerializeField]
    Color currentColor = Color.white;
    [SerializeField]
    Color futureColor = Color.gray;
    public float speed = 0.05f;
    int currentWP = 0;
    float lookAhead = 0.01f;

    float rotSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        PrepareNumberColor();
    }

    void PrepareNumberColor()
    {
        int waypointIndex = GameDataService.Instance.myPlayer.currentIndexQuestion+1;
        for (int i = 0;i<waypoints.Length;i++)
        {
            TMP_Text txt = waypoints[i].GetComponentInChildren<TMP_Text>();

            if (txt != null)
            {
                if(i<waypointIndex)
                {
                    txt.color = passColor;
                    SpriteRenderer[] sr = waypoints[i].GetComponentsInChildren<SpriteRenderer>();
                    if(sr.Length >1)
                    {
                        sr[1].gameObject.SetActive(true);
                    }
                }
                else if (i == waypointIndex)
                {
                    txt.color = currentColor;
                    SpriteRenderer[] sr = waypoints[i].GetComponentsInChildren<SpriteRenderer>();
                    if (sr.Length > 1)
                    {
                        sr[1].gameObject.SetActive(true);
                    }
                }
                else 
                {
                    txt.color = futureColor;
                    SpriteRenderer[] sr = waypoints[i].GetComponentsInChildren<SpriteRenderer>();
                    if (sr.Length > 1)
                    {
                        sr[1].gameObject.SetActive(false);
                    }
                }
            }
        }
    }

    public void SetStartWaypoint(int question)
    {
        currentWP = question;
        if (currentWP < waypoints.Length)
        {
            player.transform.position = waypoints[currentWP].transform.position;
        }
        else
        {
            Debug.LogError("question more than waypoint");
        }
    }
    // Update is called once per frame
    void Update()
    {
        ProgressMove();
    }
    public void StartMove()
    {
        isStayAtCheckpoint = false;
    }
    bool isGoToCheckpoint = false;
    bool isStayAtCheckpoint = true;
    void ProgressMove()
    {
        if (isStayAtCheckpoint)
            return;

       // float caldistance = Vector3.Distance(player.transform.position, waypoints[currentWP].transform.position);
        float caldistance = Vector2.Distance(player.transform.position, waypoints[currentWP].transform.position);
        if (caldistance <= lookAhead)
        {
            if (isGoToCheckpoint)
            {
                isStayAtCheckpoint = true;
            }
            currentWP++;
            if (currentWP >= waypoints.Length)
            {
                currentWP = 0;
            }

            WaypointObj wpObj = waypoints[currentWP].GetComponent<WaypointObj>();
            if (wpObj != null && wpObj.IsCheckpoint)
            {
                isGoToCheckpoint = true;
            }
            else
            {
                isGoToCheckpoint = false;
            }
        }
        else
        {
            float step = speed * Time.deltaTime;
            Transform target = waypoints[currentWP].transform;
            //Quaternion rotationAngle = Quaternion.LookRotation(target.position - player.transform.position);
            //player.transform.rotation = Quaternion.Slerp(player.transform.rotation, rotationAngle, Time.deltaTime * rotSpeed);
            //player.transform.position = Vector3.MoveTowards(player.transform.position, target.position, step);
            //player.transform.Translate(0, 0, speed * Time.deltaTime);

            player.transform.position = Vector2.MoveTowards(player.transform.position, target.transform.position, step);
        }
    }
    public bool IsStayAtCheckpoint()
    {
        return isStayAtCheckpoint;
    }

    public void MoveNextCheckpoint()
    {
        isStayAtCheckpoint = false;
    }
}
