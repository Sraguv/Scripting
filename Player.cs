using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
    {   
        public int coins = 0;
        public Transform attackPoint;
        public GameObject fireballPrefab;
        private int health = 10;
        public string sceneName = "Level_1";
        public void TakeDamage(int damage)
        {
            health -= damage;
            print(health);
            if (health <= 0)
            {
                EditorSceneManager.LoadScene(sceneName);
            }
            
        }
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
            }    
        }
        public void CollectCoins()
        {
            coins++;
        }
    }