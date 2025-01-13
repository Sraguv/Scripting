using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.GetComponent<Player>()!= null)
            {
            player.gameObject.GetComponent<Player>().CollectCoins();
            gameObject.SetActive(false);
            }
    }
}
