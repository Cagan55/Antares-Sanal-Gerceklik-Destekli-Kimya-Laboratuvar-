using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 currentLocation;
    private Vector3 targetPosition;
    private Vector3 targetPosition2;
    public Vector3 tableLocation;
    public Vector3 chairLocation;
    public GameObject Camera;

    public float focusTime;
    public float focusTime2;

    void Start()
    {
        targetPosition = tableLocation;
        targetPosition2 = chairLocation;
        focusTime = 0;
        focusTime2 = 0;
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        { 
            if (hit.transform.tag == "Masa")
            {
                focusTime += Time.deltaTime;
                focusTime2 = 0;
            }
            if (focusTime >= 1)
            {
                transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
            }
            if (hit.transform.tag == "Sandalye")
            {
                focusTime2 += Time.deltaTime;
                focusTime = 0;
            }
            if (focusTime2 >= 1)
            {
                transform.position = Vector3.Lerp(transform.position, targetPosition2, Time.deltaTime);
            }
        }
    }
}