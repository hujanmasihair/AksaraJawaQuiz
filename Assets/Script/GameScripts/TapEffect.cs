using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapEffect : MonoBehaviour      //Script Level2
{
    public int idDown;

    [Header("Objek Controller Soal 1 & 5")]
    public GameObject saklarDown;
    public GameObject saklarUp;
    public GameObject lightObjek;

    [Header("Objek Controller Soal 2")]
    public GameObject lemariTutup;
    public GameObject lemariBuka;
    public GameObject charSeragam;
    public GameObject charBebas;

    [Header("Objek Controller Soal 3")]
    public GameObject jendelaBuka;
    public GameObject jendelaTutup;

    void Update()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();

        noSoal_.noSoal += 0;

        if (sceneName == "NewStage2Kamar")
        {
            //Nyalakan Lampu Kamar 
            if (idDown == 1 && noSoal_.noSoal == 1)
            {
                saklarUp.SetActive(false);
                saklarDown.SetActive(true);

                lightObjek.GetComponent<SpriteRenderer>().enabled = false;

                allID();
            }

            //Buka Lemari Untuk Ganti Baju
            if (idDown == 2 && noSoal_.noSoal == 2)
            {
                lemariTutup.SetActive(false);
                lemariBuka.SetActive(true);
                charSeragam.SetActive(false);
                charBebas.SetActive(true);

                idDown = 0;

                StartCoroutine(LemariNutup());
            }

            IEnumerator LemariNutup()
            {
                yield return new WaitForSeconds(1);

                lemariTutup.SetActive(true);
                lemariBuka.SetActive(false);

                noSoal_.noSoal = 3;
            }

            //Tutup Jendela Kamar
            if (idDown == 3)
            {
                jendelaTutup.SetActive(true);
                jendelaBuka.SetActive(false);
                
                allID();
            }

            //Rapikan Bantal Kembali 
            if (idDown == 4 && noSoal_.noSoal == 4)
            {
                Debug.Log("4");
            }

            //Matikan Lampu untuk tidur
            if (idDown == 5 && noSoal_.noSoal == 5)
            {
                saklarUp.SetActive(true);
                saklarDown.SetActive(false);

                lightObjek.GetComponent<SpriteRenderer>().enabled = true;
                Debug.Log("soal1 Berhasil");

                allID();
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
