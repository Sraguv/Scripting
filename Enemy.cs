using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1; public Transform target; int damage = 2; public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {   
        if (Vector3.Distance(gameObject.transform.position, target.position) >= 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            transform.LookAt(target.position);
            animator.Play("WalkFWD");   
        }
        else
        {
            animator.Play("Attack01");
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(damage);

    }
}