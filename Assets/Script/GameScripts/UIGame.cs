using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGame : MonoBehaviour         // Script pada Control UI saat bermain
{
    public GameObject panelPepak, panelExit, panelKalah;
    public Toggle tgSound;
    public AudioSource audio;

    public int poinNow;

    //[SerializeField]
    //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

    // Start is called before the first frame update

    private void Awake()
    {
        GameObject poinS = GameObject.Find("PoinFixed");
        PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
        playerPoin.poinz += 0;

        poinNow = playerPoin.poinz;
    }

    void Start()
    {
        panelPepak.gameObject.SetActive(false);
        panelExit.gameObject.SetActive(false);
        panelKalah.gameObject.SetActive(false);
    }

    public void toResume()
    {
        panelPepak.gameObject.SetActive(false);
        panelExit.gameObject.SetActive(false);

        Time.timeScale = 1;
    }

    public void toExit()
    {
        GameObject poinS = GameObject.Find("PoinFixed");
        PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
        playerPoin.poinz = 300;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void exitPanel()
    {
        panelPepak.gameObject.SetActive(false);
        panelExit.gameObject.SetActive(true);

        Time.timeScale = 0;
    }

    public void toPepak()
    {
        panelPepak.gameObject.SetActive(true);

        Time.timeScale = 0;
        Debug.Log("toPepak");

        GameObject poinS = GameObject.Find("PoinFixed");
        PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
        playerPoin.poinz -= 10;

        if (playerPoin.poinz <= 0)
        {
            panelKalah.SetActive(true);
            playerPoin.poinz = 0;
        }

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

    public void Restart()
    {
        //kembali ke Level 1
        GameObject poinS = GameObject.Find("PoinFixed");
        PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
        playerPoin.poinz = 300;

        Application.LoadLevel("NewStage1Kelas");
    }
}
