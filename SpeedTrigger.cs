using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public GameObject player;
    public float speedFactor = 2.5f;
    void OnTriggerEnter(Collider touch)
    {
        player.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    void OnTriggerExit(Collider touch)
    {
        player.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
