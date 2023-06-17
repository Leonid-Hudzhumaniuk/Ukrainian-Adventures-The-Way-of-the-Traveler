using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusTranslete : MonoBehaviour
{
    [SerializeField] private GameObject Loc1;
    [SerializeField] private GameObject Loc2;
    [SerializeField] private GameObject Loc3;
    [SerializeField] private GameObject NowLoc;
    [SerializeField] private blackout delay;
    [SerializeField] private GameObject BusUi;
    private int Loc;// 1 независимость 2 кафк 3 рынок

    private void Update()
    {
        if (delay.a2 == 255)
        {
            switch (Loc)
            {
                case 1:
                Loc1.SetActive(true);

                    break;                
                case 2:
                    Loc2.SetActive(true);

                    break;                
                case 3:
                    Loc3.SetActive(true);

                    break;
            }
            BusUi.SetActive(false);
            NowLoc.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            BusUi.SetActive(true);
        }
    }

    public void MoveLoc()
    {
        Time.timeScale = 0;
    }

    public void Numner(int Location)
    {
        Loc = Location;
    }
}