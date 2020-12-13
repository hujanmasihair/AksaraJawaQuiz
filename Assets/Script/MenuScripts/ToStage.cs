using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStage : MonoBehaviour        //Script Pemilihan Level
{
    //ke Scene 
    public void toMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    //ke Scene Stage 1
    public void toStage1()
    {
        SceneManager.LoadScene("Stage1Kelas", LoadSceneMode.Single);
    }

    //ke Scene Stage 2
    public void toStage2()
    {
        SceneManager.LoadScene("Stage2Kamar", LoadSceneMode.Single);
    }

    //ke Scene Stage 3
    public void toStage3()
    {
        SceneManager.LoadScene("Stage3Jalanan", LoadSceneMode.Single);
    }
}
