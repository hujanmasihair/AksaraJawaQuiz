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
                GameObject TapFX = GameObject.Find("TapEffect");
                TapEffect idDown_ = TapFX.GetComponent<TapEffect>();
                idDown_.idDown = idObjek;
            }
        }

        if (sceneName == "NewStage3Museum")
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject TapFX3 = GameObject.Find("TapEffect3");
                TapEffect3 idDown_ = TapFX3.GetComponent<TapEffect3>();
                idDown_.idDown = idObjek;
            }
        }
    }
}
