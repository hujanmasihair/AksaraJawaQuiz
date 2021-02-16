using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapSystem : MonoBehaviour          //Script Tipe Tap
{
    public int idObjek;

    private GameObject TapFX;
    private void OnMouseDown()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "NewStage2Kamar")
        {
            if (Input.GetMouseButtonDown(0))
            {
                //ambil data Script TapEffect
                GameObject TapFX = GameObject.Find("TapEffect");
                TapEffect idDown_ = TapFX.GetComponent<TapEffect>();
                idDown_.idDown = idObjek;

                aturSuara();
            }
        }

        if (sceneName == "NewStage3Museum")
        {
            if (Input.GetMouseButtonDown(0))
            {
                //ambil data Script TapEffect3
                GameObject TapFX3 = GameObject.Find("TapEffect3");
                TapEffect3 idDown_ = TapFX3.GetComponent<TapEffect3>();
                idDown_.idDown = idObjek;

                aturSuara();
            }
        }
    }

    public void aturSuara()
    {
        //ambil data QuickTest
        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();

        //ambil data Script QuizManager
        GameObject setAudio = GameObject.Find("SetAudio");
        AudioJawaban other = (AudioJawaban)setAudio.GetComponent(typeof(AudioJawaban));

        //Mengatur Suara Jawaban Benar dan Salah
        if (idObjek == noSoal_.noSoal)
        {
            other.rightAudio();
        }

        else if (idObjek != noSoal_.noSoal)
        {

            other.wrongAudio();

            GameObject poinS = GameObject.Find("PoinFixed");
            PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
            playerPoin.poinz -= 20;

            //Statemen atasi error pemilihan 2 pahlawan
            if(idObjek == 1 && noSoal_.noSoal == 0)
            {
                other.rightAudio();
                other.muteWrongAudio();
                playerPoin.poinz += 20;
            }
        }
    }
}
