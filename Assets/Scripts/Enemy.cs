using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        this.transform.up = Player.PL.transform.position - this.transform.position;
        rb.velocity = new Vector3(this.transform.up.x, this.transform.up.y, this.transform.up.z);
    }
}
