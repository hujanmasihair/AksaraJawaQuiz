using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject UIMenu, UIStage, UISetting, UIPepak;
    public Toggle tgSound;
    public AudioSource audio;


    void Start()
    {
        UIMenu.SetActive(true);
        UIPepak.gameObject.SetActive(false);
        UISetting.gameObject.SetActive(false);
    }

    //menonaktifkan semua UI kecuali Menu Level
    public void toPlay()
    {
        UIMenu.SetActive(false);
        UIStage.SetActive(true);
        UISetting.SetActive(false);
        UIPepak.SetActive(false);
    }

    public void toPlay2()
    {
        SceneManager.LoadScene("Stage1Kelas", LoadSceneMode.Single);
    }

    //menonaktifkan semua UI kecuali Pengaturan
    public void toSet()
    {
        UIMenu.SetActive(false);
        UIStage.SetActive(false);
        UISetting.SetActive(true);
        UIPepak.SetActive(false);
    }

    //menonaktifkan semua UI kecuali Pepak
    public void toPepak()
    {
        UIPepak.SetActive(true);
    }

    public void toResume()
    {
        UIPepak.SetActive(false);
    }

    //menonaktifkan semua UI kecuali Tampilan Awal
    public void toHome()
    {
        UIMenu.SetActive(true);
        UIStage.SetActive(false);
        UISetting.SetActive(false);
        UIPepak.SetActive(false);
    }

    //Keluar dari permainan
    public void DoQuit()
    {
        Application.Quit();
    }

    public void soundCtrl()
    {
        if (tgSound.isOn)
        {
            audio.Play();
        }

        if (!tgSound.isOn)
        {
            audio.Pause();
        }
    }
}
