using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayerPos : MonoBehaviour
{
    [SerializeField] private Vector3 spawn;
    [SerializeField] private Transform player;
    void Start()
    {
        player.position = spawn;
    }


}
