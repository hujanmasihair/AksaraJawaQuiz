using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berhasil : MonoBehaviour
{
    private int poinMenang;
    private int poinSekarang;

    public GameObject barang;

    // Start is called before the first frame update
    void Start()
    {
        poinMenang = barang.transform.childCount;
    }

    // Jika Menang
    void Update()
    {
        if(poinSekarang >= poinMenang)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void tambahPoin()
    {
        poinSekarang++;
    }
}
