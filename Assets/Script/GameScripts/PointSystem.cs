using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour        //Script Point (pengurangan saat membuka pepak)
{
    public Text jmlPoin, poinSt;
    public UIGame uiGame;
    public int poinz;


    // Start is called before the first frame update
    void Start()
    {
        GameObject poinS = GameObject.Find("Controller");
        UIGame playerPoin = poinS.GetComponent<UIGame>();
        playerPoin.poinNow += 0;

        poinz = playerPoin.poinNow;

        jmlPoin.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        poinSt.text = poinz.ToString();
        jmlPoin = poinSt;
    }
}
