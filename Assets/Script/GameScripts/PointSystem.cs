using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour        //Script Point (pengurangan saat membuka pepak)
{
    public Text jmlPoin, poinSt;
    public UIGame uiGame;
    public int poinz;
    public GameObject GameOverUI;

    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
        GameObject poinS = GameObject.Find("Controller");
        UIGame playerPoin = poinS.GetComponent<UIGame>();
        playerPoin.poinNow += 0;

        poinz = playerPoin.poinNow;

        jmlPoin.GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        poinSt.text = poinz.ToString();
        jmlPoin = poinSt;
    }

    private void FixedUpdate()
    {
        if (poinz <= 0)
        {
            GameOverUI.SetActive(true);
            poinz = 300;
        }
    }
}
