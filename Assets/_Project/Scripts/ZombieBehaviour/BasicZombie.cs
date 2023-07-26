using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicZombie : MonoBehaviour, CoreZombieBehaviour
{
    Rigidbody zombie;
    float MovementSpeed=0.75f;
    void Start()
    {
        zombie = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Move();
    }
    public void Attack()
    {
        throw new System.NotImplementedException();
    }
    public void Move()
    {
        zombie.AddForce(0,0,MovementSpeed);
    }
}
