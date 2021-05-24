using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private bool Pause = false;
    public static AudioSource[] S;
    public static Text Sc;
    public static int C;
    public static int SCR;
    public static bool DALL;
    public static int R;
    public static GameObject[] TTT;
    public void Start()
    {
        TTT = GameObject.FindGameObjectsWithTag("UI");
        C = 0;
        SCR = 50;
        DALL = false;
        Pause = false;
        S = this.GetComponents<AudioSource>();
        Sc = GameObject.Find("Score").GetComponent<Text>();
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void FullHP()
    {
        Player.lives = 5;
        Time.timeScale = 1;
        while (GameObject.FindGameObjectsWithTag("UPGR").Length != 0)
        {
            GameObject.FindGameObjectWithTag("UPGR").SetActive(false);
        }
    }

    public void DestroyAll()
    {
        DALL = true;
        Time.timeScale = 1;
        while (GameObject.FindGameObjectsWithTag("UPGR").Length != 0)
        {
            GameObject.FindGameObjectWithTag("UPGR").SetActive(false);
        }
    }

    public void ScoreUpp()
    {
        Time.timeScale = 1;
        SCR *= 2;
        while (GameObject.FindGameObjectsWithTag("UPGR").Length != 0)
        {
            GameObject.FindGameObjectWithTag("UPGR").SetActive(false);
        }
    }

    public void CloseUI()
    {
        foreach (GameObject Element in TTT)
        {
            Element.SetActive(false);
        }
    }

    public void OpenUI()
    {
        foreach (GameObject Element in TTT)
        {
            Element.SetActive(true);
        }
    }

    public void PauseButton()
    {
        if (Pause == false)
        {
            Time.timeScale = 0;
            Pause = true;
            CloseUI();
        }
        else
        {
            Time.timeScale = 1;
            Pause = false;
            OpenUI();
        }
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public static void AddScore()
    {
        C += SCR + Random.Range(1, 50);
        Sc.text = C.ToString();
    }

    public static void Swing()
    {
        R = Random.Range(1, 3);
        S[R].pitch = Random.Range(1f, 1.5f);
        S[R].Play();
    }

    public void LeftUpButton()
    {
        Player.PL.transform.eulerAngles = new Vector3(0,0,225);
        Player.PL.transform.localPosition = new Vector3(23.4f, 220.3f, -14062.25f);
        Swing();
        if (DALL == false)
            {AttackLU.isEnemy();}
        else { Destroy(GameObject.FindGameObjectWithTag("Enemy"));}
    }

    public void RightUpButton()
    {
        Player.PL.transform.localEulerAngles = new Vector3(0, 0, 135);
        Player.PL.transform.localPosition = new Vector3(61.5f, 134.2f, -14062.25f);
        Swing();
        if (DALL == false)
        { AttackRU.isEnemy(); }
        else { Destroy(GameObject.FindGameObjectWithTag("Enemy")); }
    }

    public void LeftDownButton()
    {
        Player.PL.transform.eulerAngles = new Vector3(0, 0, 315);
        Player.PL.transform.localPosition = new Vector3(-62.3f, 179f, -14062.25f);
        Swing();
        if (DALL == false)
        { AttackLD.isEnemy(); }
        else { Destroy(GameObject.FindGameObjectWithTag("Enemy")); }
    }

    public void RightDownButton()
    {
        Player.PL.transform.localEulerAngles = new Vector3(0, 0, 40);
        Player.PL.transform.localPosition = new Vector3(-27.8f, 96.7f, -14062.25f);
        Swing();
        if (DALL == false)
        { AttackRD.isEnemy(); }
        else { Destroy(GameObject.FindGameObjectWithTag("Enemy")); }
    }
}
