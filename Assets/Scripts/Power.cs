using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{

    public GameObject obj;
    public AudioClip _switchOn;
    public AudioSource _audioSource;
    
    /*
    private void OnMouseDown()
    {
        Debug.Log("clicked");
        if (obj.activeSelf)
        {
            obj.SetActive(false);
            _audioSource.clip = _switchOn;
            _audioSource.Stop();
        }
        else
        {
            obj.SetActive(true);
            _audioSource.clip = _switchOn;
            _audioSource.Play();
        }
    }
   */

//   /*
    bool collision;
    private void OnTriggerEnter(Collider other)
    {
        collision = true;
    }
    private void OnTriggerStay(Collider other)
    {
        collision = false;
    }
    private void OnTriggerExit(Collider other)
    {
        collision = false;
    }
   
    private void Update()
    {
        if(collision)
        {
            Debug.Log("clicked");
            if (obj.activeSelf)
            {
                obj.SetActive(false);
                _audioSource.clip = _switchOn;
                _audioSource.Play();
            }
            else
            {
                obj.SetActive(true);
                _audioSource.clip = _switchOn;
                _audioSource.Play();
            }
        }
    }
//*/
}
