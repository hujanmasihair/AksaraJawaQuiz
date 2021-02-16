using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioJawaban : MonoBehaviour
{

    public AudioSource salahJwb, benarJwb;

    public void wrongAudio()
    {
        salahJwb.Play();
    }

    public void muteWrongAudio()
    {
        salahJwb.mute = true;
        StartCoroutine(MuteOff());
    }

    IEnumerator MuteOff()
    {
        yield return new WaitForSeconds(0.3f);
        salahJwb.mute = false;
    }

    public void rightAudio()
    {
        benarJwb.Play();
    }
}
