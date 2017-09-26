using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript2 : MonoBehaviour
{

    public Light light;
    public GameObject goLightSwitch;
    private bool _switchon;
    private GameObject _upposition;
    private GameObject _downposition;
    public AudioClip _switchOn;
    public AudioSource _audioSource;

    void Awake()
    {
        _upposition = GameObject.Find("upPosition1");
        _downposition = GameObject.Find("downPosition1");
    }

    /*
    void OnMouseDown()
    {
        if (_switchon)
        {
            _switchon = false;
            goLightSwitch.transform.position = new Vector3(_downposition.transform.position.x, _downposition.transform.position.y, _downposition.transform.position.z);
            light.enabled = false;
            _audioSource.clip = _switchOn;
            _audioSource.Play();
        }
        else if (!_switchon)
        {
            _switchon = true;
            goLightSwitch.transform.position = new Vector3(_upposition.transform.position.x, _upposition.transform.position.y, _upposition.transform.position.z);
            light.enabled = true;
            _audioSource.clip = _switchOn;
            _audioSource.Play();
        }
    }
    */

//    /*
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
        if(collision==true)    
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
//*/
}
