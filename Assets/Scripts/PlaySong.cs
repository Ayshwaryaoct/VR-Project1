using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour {
    public AudioClip _switchOn;
    public AudioSource _audioSource;
    /*
    private void OnMouseDown()
    {
        _audioSource = GetComponent<AudioSource>();
        Debug.Log("pressed");
        _audioSource.clip = _switchOn;
        _audioSource.Play();
    }
   */


///*
    bool triggered = true;
    bool collision;

    private void OnTriggerEnter(Collider other)
    {
        collision = true;
    }
    private void OntriggerStay(Collider other)
    {
        collision = true;
    }
    private void OnTriggerExit(Collider other)
    {
        collision = false;
    }

    void Update()
    {
        if (collision == true)
        {
            if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost)).GetHairTriggerDown())
            {
                if (triggered)
                {
                    triggered = false;
                    _audioSource.clip = _switchOn;
                    _audioSource.Play();
                }
                else if (!triggered)
                {
                    triggered = true;
                    _audioSource.clip = _switchOn;
                    _audioSource.Stop();
                }
            }
        }
    }
//*/
}
