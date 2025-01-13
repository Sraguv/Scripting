using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    void OnTriggerEnter(Collider touch)
    {
        touch.gameObject.GetComponent<Transform>().position = teleportPoint.position;
    }
}
