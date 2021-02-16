using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoinAkhir : MonoBehaviour
{

    public int scoreAkhir;
    public Text jmlPoin, poinSt;


    // Start is called before the first frame update
    void Start()
    {
        GameObject poinS = GameObject.Find("PoinFixed");
        PoinFixed playerPoin = poinS.GetComponent<PoinFixed>();
        scoreAkhir =  playerPoin.poinz;
        Debug.Log("scoreAkhir : " + scoreAkhir);
        
        jmlPoin.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        poinSt.text = scoreAkhir.ToString();
        jmlPoin = poinSt;

        Debug.Log("scoreAkhir Text : " + scoreAkhir);
    }
}
