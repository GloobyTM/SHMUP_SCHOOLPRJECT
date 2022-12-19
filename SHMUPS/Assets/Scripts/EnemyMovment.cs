using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    [Header("Set in inspector")]
    private float speed = 10f;
    public float fireRate = 0.3f;
    public float health = 10f;
    public int score = 50;

    //public Vector3 pos
    //{
    //    //get 
    //    //{ 
    //    //    return transform.position;
    //    //}
    //    //set 
    //    //{
    //    //this.transform.position= value;
    //    //}
    //}
    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }
}
