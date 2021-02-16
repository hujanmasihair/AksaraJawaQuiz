using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizManager : MonoBehaviour        //Script Menampilkan Soal Secara Urut pada semua level
{
    public int noSoal;
    Text soal;
    //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

    public GameObject panelIntro, panelMenang, btnNext;
    public GameObject q1, q2, q3, q4, q5;

    void Start()
    {
        soal = GetComponent<Text>();
        panelMenang.gameObject.SetActive(false);

        //Menampilkan Intro
        panelIntro.gameObject.SetActive(true);

        //menampilkan soal mana yang ditampilkan / tidak
        q1.gameObject.SetActive(true);
        q2.gameObject.SetActive(false);
        q3.gameObject.SetActive(false);
        q4.gameObject.SetActive(false);
        q5.gameObject.SetActive(false);


        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();

        noSoal_.noSoal = 0;
    }

    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;


        if (noSoal == 1)
        {
            q1.gameObject.SetActive(true);
            q2.gameObject.SetActive(false);
            q3.gameObject.SetActive(false);
            q4.gameObject.SetActive(false);
            q5.gameObject.SetActive(false);
        }

        else if (noSoal == 2)
        {
            q1.gameObject.SetActive(false);
            q2.gameObject.SetActive(true);
            q3.gameObject.SetActive(false);
            q4.gameObject.SetActive(false);
            q5.gameObject.SetActive(false);
        }

        else if (noSoal == 3)
        {
            q1.gameObject.SetActive(false);
            q2.gameObject.SetActive(false);
            q3.gameObject.SetActive(true);
            q4.gameObject.SetActive(false);
            q5.gameObject.SetActive(false);
        }

        else if (noSoal == 4)
        {
            q1.gameObject.SetActive(false);
            q2.gameObject.SetActive(false);
            q3.gameObject.SetActive(false);
            q4.gameObject.SetActive(true);
            q5.gameObject.SetActive(false);
        }

        else if (noSoal == 5)
        {
            q1.gameObject.SetActive(false);
            q2.gameObject.SetActive(false);
            q3.gameObject.SetActive(false);
            q4.gameObject.SetActive(false);
            q5.gameObject.SetActive(true);
        }

        else if (noSoal >= 6)
        {
            Debug.Log("Menang");
            //SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            q1.gameObject.SetActive(false);
            q2.gameObject.SetActive(false);
            q3.gameObject.SetActive(false);
            q4.gameObject.SetActive(false);
            q5.gameObject.SetActive(false);

            StartCoroutine(lanjutScene());

        }
    }

    IEnumerator lanjutScene()
    {
        yield return new WaitForSeconds(1f);

        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    public void masukQuiz()
    {
        panelIntro.gameObject.SetActive(false);
        btnNext.gameObject.SetActive(false);

        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();

        noSoal_.noSoal = 1;
        //Debug.Log("aa" + noSoal_.noSoal);
    }
    
    public void masukQuizLv3()
    {
        panelIntro.gameObject.SetActive(false);
        btnNext.gameObject.SetActive(false);

        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();

        noSoal_.noSoal = 0;

        GameObject setAudio = GameObject.Find("SetAudio");
        AudioJawaban other = (AudioJawaban)setAudio.GetComponent(typeof(AudioJawaban));

        other.muteWrongAudio();

        GameObject poinS = GameObject.Find("PoinFixed");
        PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
        playerPoin.poinz += 20;
        //Debug.Log("aa" + noSoal_.noSoal);
    }
}
