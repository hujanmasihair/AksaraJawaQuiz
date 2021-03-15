using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoinFixed : MonoBehaviour
{
    //set awal poin
    public int poinz;

    private static Dictionary<string, GameObject> _instances = new Dictionary<string, GameObject>();
    public string ID;

    private void Awake()
    {
        poinz = 300;

        //Continue Object di Beda Scene
        if (_instances.ContainsKey(ID))
        {
            var existing = _instances[ID];

            // A null result indicates the other object was destoryed for some reason
            if (existing != null)
            {
                if (ReferenceEquals(gameObject, existing))
                    return;

                Destroy(gameObject);

                // Return to skip the following registration code
                return;
            }
        }

        // The following code registers this GameObject regardless of whether it's new or replacing
        _instances[ID] = gameObject;

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void FixedUpdate()
    {
        Time.timeScale = 1;

        //Set Poin di UI sesuai poin awal
        GameObject poinS = GameObject.Find("PoinSekarang");
        PointSystem playerPoin = poinS.GetComponent<PointSystem>();
        playerPoin.poinz = poinz;
        //poinz = playerPoin.poinz

        if (poinz <= 0)
        {
            //poinz = 300;
            poinz = playerPoin.poinz;
                Debug.Log("PPP : " + poinz);

        }

    }
}
