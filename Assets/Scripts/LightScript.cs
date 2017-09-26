using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light light;
    public GameObject goLightSwitch;
    private bool test=true;
    private GameObject _upposition;
    private GameObject _downposition;
    public AudioClip _switchOn;
    public AudioSource _audioSource;
    void Awake()
    {
        _upposition = GameObject.Find("upPosition");
        _downposition = GameObject.Find("downPosition");
    }
    ///*
    void OnMouseDown()
    {
        if(test)
        {
            test = false;
            goLightSwitch.transform.position = new Vector3(_downposition.transform.position.x, _downposition.transform.position.y, _downposition.transform.position.z);
            light.enabled = false;
            _audioSource.clip = _switchOn;
            _audioSource.Play();
        }
        else if(!test)
        {
            test = true;
            goLightSwitch.transform.position = new Vector3(_upposition.transform.position.x, _upposition.transform.position.y, _upposition.transform.position.z);
            light.enabled = true;
            _audioSource.clip = _switchOn;
            _audioSource.Play();
        }
   }
    //*/


   /*
    bool triggered=true;
    bool collision;
    
    private void OnTriggerEnter(Collider other)
    {
        collision=true;   
    }
    private void OntriggerStay(Collider other)
    {
        collision=true;
    }
    private void OnTriggerExit(Collider other)
    {
        collision=false;
    }

    void Update()
    {
       if (collision==true)    
        {
            if (SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost)).GetHairTriggerDown())
            {
                if (triggered)
                {
                    triggered = false;
                    goLightSwitch.transform.position = new Vector3(_downposition.transform.position.x, _downposition.transform.position.y, _downposition.transform.position.z);
                    light.enabled = false;
                    _audioSource.clip = _switchOn;
                    _audioSource.Play();
                }
                else if (!triggered)
                {
                    triggered = true;
                    goLightSwitch.transform.position = new Vector3(_upposition.transform.position.x, _upposition.transform.position.y, _upposition.transform.position.z);
                    light.enabled = true;
                    _audioSource.clip = _switchOn;
                    _audioSource.Play();
                }
            }
        }
    }
*/
}
