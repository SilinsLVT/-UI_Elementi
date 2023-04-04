using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAttela : MonoBehaviour {

    public AudioSource kurAtsakanot;
    public AudioClip koAtskanot;

    public void uzAttela()
    {
        kurAtsakanot.PlayOneShot(koAtskanot);
    }
    public void noAttela()
    {
        kurAtsakanot.Stop();
    }

}