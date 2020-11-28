using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    public GameObject panelPepak, panelExit, panelKalah;
    public Toggle tgSound;
    public AudioSource audio;

    public int poinNow;

    [SerializeField]
    int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

    // Start is called before the first frame update
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

        GameObject poinS = GameObject.Find("PoinSekarang");
        PointSystem playerPoin = poinS.GetComponent<PointSystem>();
        playerPoin.poinz -= 20;

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
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Lanjut()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
}
