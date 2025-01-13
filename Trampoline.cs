using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter(Collider touch)
    {
        player.GetComponent<Jump>().jumpStrength = 10;
    }
    void OnTriggerExit(Collider touch)
    {
        player.GetComponent<Jump>().jumpStrength = 2;
    }
}
