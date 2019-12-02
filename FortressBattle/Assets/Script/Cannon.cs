using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public KeyCode fire;
    public Transform firepoint;
    public GameObject bullet;
    public Rigidbody2D structure;
    public float knockback = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fire))
        {
            shoot();
            structure.AddForce(new Vector2 (-knockback, 0));
        }
    }

    void shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
