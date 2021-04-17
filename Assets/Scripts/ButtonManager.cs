using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private bool Pause = false;
    private float t = 0.0f;
    public void Start()
    {
        Pause = false;
        t = 0f; 
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void PauseButton()
    {
        if (Pause == false)
        {
            Time.timeScale = 0;
            Pause = true;
        }
        else
        {
            Time.timeScale = 1;
            Pause = false;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void LeftUpButton()
    {
        Player.PL.transform.eulerAngles = new Vector3(0,0,225);
        Player.PL.transform.localPosition = new Vector3(23.4f, 220.3f, -14062.25f);
        AttackLU.isEnemy();
    }

    public void RightUpButton()
    {
        Player.PL.transform.localEulerAngles = new Vector3(0, 0, 135);
        Player.PL.transform.localPosition = new Vector3(61.5f, 134.2f, -14062.25f);
        AttackRU.isEnemy();
    }

    public void LeftDownButton()
    {
        Player.PL.transform.eulerAngles = new Vector3(0, 0, 315);
        Player.PL.transform.localPosition = new Vector3(-62.3f, 179f, -14062.25f);
        AttackLD.isEnemy();
    }

    public void RightDownButton()
    {
        Player.PL.transform.localEulerAngles = new Vector3(0, 0, 40);
        Player.PL.transform.localPosition = new Vector3(-27.8f, 96.7f, -14062.25f);
        AttackRD.isEnemy();
    }
}
