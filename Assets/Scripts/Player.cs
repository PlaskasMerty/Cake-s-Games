using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public static GameObject PL;
    private Rigidbody2D _body2d;
    public static int lives = 5;
    
    public static int Lives
    {
        get { return lives; }
        set
        {
            if (lives == 0)
            {
                Time.timeScale = 0;
                SceneManager.LoadScene("MainMenu");
            }

            if (value < 6)
            {
                lives = value;
            }
            livesBar.Refresh();
        }
    }
    public static LivesBar livesBar;

    private void Awake()
    {
        livesBar = FindObjectOfType<LivesBar>();
    }

    void Start()
    {
        Time.timeScale = 1;
        _body2d = GetComponent<Rigidbody2D>();
        PL = this.gameObject;
    }
}
