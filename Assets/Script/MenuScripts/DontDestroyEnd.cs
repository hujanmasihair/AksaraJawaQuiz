using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyEnd : MonoBehaviour
{
    private GameObject removeD;
    // Start is called before the first frame update
    void Start()
    {
        removeD = GameObject.Find("PoinFixed");
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(removeD);
    }
}
