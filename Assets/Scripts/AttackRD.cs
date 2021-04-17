using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRD : MonoBehaviour
{
    public static bool Yes = false;
    public static GameObject En;


    public void Start()
    {
        Yes = false;
    }

    public static void isEnemy()
    {
        if (Yes)
        {
            En.SetActive(false);
            //Destroy(En);
            Yes = false;
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            En = collider.GetComponent<GameObject>();
            Yes = true;
            En = collider.gameObject;
        }
    }

}
