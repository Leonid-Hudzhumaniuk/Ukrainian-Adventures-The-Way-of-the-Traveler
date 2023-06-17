using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 
    transition : MonoBehaviour
{
    [SerializeField] private GameObject NextLoc;
    [SerializeField] private GameObject NowLoc;
    [SerializeField] private blackout delay;

    private void Update()
    {
        if (delay.a2 == 255)
        {
            NextLoc.SetActive(true);
            NowLoc.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            delay.MoveUp();
        }
    }


}
