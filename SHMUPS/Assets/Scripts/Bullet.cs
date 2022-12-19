using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //speed that will be applied to the bullet
    [SerializeField] private float speed = 65f;
    void Start()
    {
        //destroys the gameobject(the bullet) after 4f (4 seconds after spawning)
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        //add the speed to the transform of the object and
        transform.Translate(0,0,speed * Time.deltaTime);
    }
}
