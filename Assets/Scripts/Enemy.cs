using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Rigidbody2D rb;
    public static float InvTime = 3.0f;
    public static float t = 0.0f;
    public GameObject PF;
    public GameObject time;
  
    void FixedUpdate()
    {
        this.transform.up = Player.PL.transform.position - this.transform.position;
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(this.transform.up.x, this.transform.up.y, this.transform.up.z);
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (t > InvTime)
        {
            t = 0.0f;
            if (collider.tag == "Player")
            {
                time = Instantiate(PF, this.transform.position, Quaternion.identity,this.transform);
                Destroy(time, 0.1f);
                Player.Lives--;
            }
        }
        t += Time.deltaTime;
    }

}
