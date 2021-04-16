using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
    }


    public void LeftUpButton()
    {
        Player.PL.transform.eulerAngles = new Vector3(0,0,225);
        Player.PL.transform.localPosition = new Vector3(23.4f, 220.3f, -14062.25f);
    }

    public void RightUpButton()
    {
        Player.PL.transform.localEulerAngles = new Vector3(0, 0, 135);
        Player.PL.transform.localPosition = new Vector3(61.5f, 134.2f, -14062.25f);
    }

    public void LeftDownButton()
    {
        Player.PL.transform.eulerAngles = new Vector3(0, 0, 315);
        Player.PL.transform.localPosition = new Vector3(-62.3f, 179f, -14062.25f);
    }

    public void RightDownButton()
    {
        Player.PL.transform.localEulerAngles = new Vector3(0, 0, 40);
        Player.PL.transform.localPosition = new Vector3(-27.8f, 96.7f, -14062.25f);
    }

}
