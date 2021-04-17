using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static GameObject PL;
    private Rigidbody2D _body2d;
    public static int lives = 10;
    public int Lives
    {
        get { return lives; }
        set
        {
            //if (value == 0)
            //{
            //    RestartLevel.Restart();
            //}
            if (value < 10) lives = value;
            livesBar.Refresh();
        }
    }
    private LivesBar livesBar;

    void Start()
    {
        _body2d = GetComponent<Rigidbody2D>();
        PL = this.gameObject;
    }

    // void OnTriggerStay2D(Collider2D collider)
    //{
    //    if (t > InvTime)
    //    {
    //        t = 0.0f;
    //        if (collider.tag == "Enemy")
    //        {
    //            Player.lives -= 1;
    //            l -= 1;            
    //        }
    //    }
    //    t += Time.deltaTime;
    //}

}
