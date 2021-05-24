using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLU : MonoBehaviour
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
            ButtonManager.S[3].pitch = Random.Range(0.1f,1f);
            ButtonManager.S[3].Play();
            ButtonManager.AddScore();
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

