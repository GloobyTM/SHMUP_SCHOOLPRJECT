using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public Player S;

    [Header("Set in Inspector")]

    public float speed = 30;
    //public float rollMult = -45;
    //public float PitchMult = 30;

    [Header("Set Dynamically")]
    public float sheildlevel = 1;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;

    void Awake()
    {
        if (S == null)
        {
            S = this;
        }
        else
        {
            Debug.LogError("Hero.Awake() - attempted to assign second hero.S!");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(xAxis, zAxis);
        direction.Normalize();
        Vector3 pos = transform.position;
        pos.x += direction.x * speed * Time.deltaTime;
        pos.z += direction.y * speed * Time.deltaTime;
        transform.position = pos;

        //transform.rotation = Quaternion.Euler(zAxis * PitchMult, xAxis * PitchMult, 0);

        //Shooting when the player presses space!
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, transform.rotation);
        Vector3 eulerAngles = newBullet.transform.eulerAngles;
        eulerAngles.x = 0f;
        newBullet.transform.eulerAngles = eulerAngles;

        
    }
}

