using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapEffect3 : MonoBehaviour         //Script Level 3
{
    public int idDown;
    public GameObject pahlawan, panelMenang;

    void Update()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();

        noSoal_.noSoal += 0;

        if (sceneName == "NewStage3Museum")
        {

            //Tap Pahlawan 1 ( Ir. Soekarno )
            if (idDown == 1 && noSoal_.noSoal == 0)
            {
                allID();
                Debug.Log("1 = " + noSoal_.noSoal);
                //pahlawan.GetComponent<Collider2D>().enabled = false;
            }

            //Tap Pahlawan 2 ( Bung Tomo )
            if (idDown == 1 && noSoal_.noSoal == 1)
            {
                allID();
                Debug.Log("1 = " + noSoal_.noSoal);
                //pahlawan.GetComponent<Collider2D>().enabled = false;
            }

            //Tap Keris
            if (idDown == 2 && noSoal_.noSoal == 2)
            {
                allID();
                Debug.Log("2 = " + noSoal_.noSoal);

            }

            //Tap Patung 2014
            if (idDown == 3 && noSoal_.noSoal == 3)
            {
                allID();
                Debug.Log("3 = " + noSoal_.noSoal);

            }

            //Tap Peta
            if (idDown == 4 && noSoal_.noSoal == 4)
            {
                allID(); 
                Debug.Log("4 = " + noSoal_.noSoal);

            }

            //Tap Garuda
            if (idDown == 5 && noSoal_.noSoal == 5)
            {
                allID();
                Debug.Log("5 = " + noSoal_.noSoal);
            }

            // Level 3 Menang
            if (noSoal_.noSoal >= 6)
            {
                panelMenang.SetActive(true);
            }
        }
    }

    public void allID()
    {

        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();
        noSoal_.noSoal += 0;

        idDown = 0;
        noSoal_.noSoal += 1;

    }
}
