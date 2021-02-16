using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSystem : MonoBehaviour         //Script Tipe Drag n Drop
{
    public GameObject correctPlace;
    private bool pindah, finish;

    public QuizManager Qmng;

    public int idObjek;
    private int idDown;
    //public int noSoal;

    private float startPosX, startPosY;

    private Vector3 resetPosition;

    Text soal;


    // Start is called before the first frame update
    void Start()
    {
        //menentukan posisi awal objek guna reset posisi nantinya
        resetPosition = this.transform.localPosition;

        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();
        noSoal_.noSoal = 0;

        //idObjek = GameObject.Find("1");
        //Debug.Log("noSoal : " + noSoal_.noSoal);
    }

    // Update is called once per frame
    void Update()
    {
        if(finish == false)
        {
            if (pindah)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
    }

    private void OnMouseDown()
    {
        //ketika objek disentuh
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            pindah = true;

            idDown = idObjek;
            Debug.Log("idDown = " + idDown);
        }
    }

    private void OnMouseUp()
    {

        //ketika objek dilepas
        pindah = false;
        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();

        //menyesuaikan posisi 
        if (Mathf.Abs(this.transform.localPosition.x - correctPlace.transform.localPosition.x) <= 0.5f &&
           Mathf.Abs(this.transform.localPosition.y - correctPlace.transform.localPosition.y) <= 0.5f &&
           idDown == noSoal_.noSoal)
        {
            this.transform.position = new Vector3(correctPlace.transform.position.x, correctPlace.transform.position.y, correctPlace.transform.position.z);
            finish = true;

            GameObject setAudio = GameObject.Find("SetAudio");
            AudioJawaban other = (AudioJawaban)setAudio.GetComponent(typeof(AudioJawaban));
            other.rightAudio();

            //GameObject.Find("PointHandler").GetComponent<Berhasil>().tambahPoin();
            this.GetComponent<Collider2D>().enabled = false;
            callQMng();
        }
        else
        {   
            //mengembalikan keposisi awal
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);

            GameObject setAudio = GameObject.Find("SetAudio");
            AudioJawaban other = (AudioJawaban)setAudio.GetComponent(typeof(AudioJawaban));
            other.wrongAudio();

            GameObject poinS = GameObject.Find("PoinFixed");
            PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
            playerPoin.poinz -= 20;

        }
    }

    private void callQMng()
    {
        GameObject QMng = GameObject.Find("QuizText");
        QuizManager noSoal_ = QMng.GetComponent<QuizManager>();
        noSoal_.noSoal++;

        Debug.Log("noSoal : " + noSoal_.noSoal);
    }
}
