using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizManager : MonoBehaviour
{
    public int noSoal;
    Text soal;

    public string jawa;
    public Font hanacarakaFont;

    public Text yourText;

    public GameObject panelMenang;

    void Start()
    {
        //label.GetComponent<Text>().font = hanacarakaFont;
        soal = GetComponent<Text>();
        //jawa.font = hanacarakaFont;

        //To load it:
        //Font font = Resources.Load("Fonts/Hanacaraka.ttf") as Font;

        panelMenang.gameObject.SetActive(false);

        //To assign it to the Text component:
        //yourText.font = font;
    }

    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if(sceneName == "Stage1Kelas")
        {
            if (noSoal == 1)
            {
                soal.text = "Masukan Buku Kedalam Tas " + yourText;
            }

            else if (noSoal == 2)
            {
                soal.text = "Buang remasan kertas kedalam tempat sampah";
            }

            else if (noSoal == 3)
            {
                soal.text = "Masukkan penggaris kedalam kotak pensil";
            }

            else if (noSoal == 4)
            {
                soal.text = "Taruh Globe ke meja kiri";
            }

            else if (noSoal == 5)
            {
                soal.text = "Pasang Jam di tembok diatas Tanaman";
            }

            else
            {
                //Debug.Log("Menang");
            }
        }

        if (sceneName == "Stage2Kamar")
        {
            if (noSoal == 1)
            {
                soal.text = "Buang Kertas ke Tempat Sampah";
                Debug.Log(soal.text);
            }

            else if (noSoal == 2)
            {
                soal.text = "Buang remasan kertas kedalam tempat sampah";
            }

            else if (noSoal == 3)
            {
                soal.text = "Masukkan penggaris kedalam kotak pensil";
            }

            else if (noSoal == 4)
            {
                soal.text = "Taruh Globe ke meja kiri";
            }

            else if (noSoal == 5)
            {
                soal.text = "Pasang Jam di tembok diatas Tanaman";
            }

            else if (noSoal == 6)
            {
                Debug.Log("Menang");
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            }
        }

        if (noSoal == 6)
        {
            panelMenang.gameObject.SetActive(true);

            Debug.Log("Menang");
        }


    }
}
