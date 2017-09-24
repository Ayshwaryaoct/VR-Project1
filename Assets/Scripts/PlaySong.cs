using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour {
    public AudioClip switchOn;
    public AudioSource _audioSource;
    private void OnMouseDown()
    {
        _audioSource = GetComponent<AudioSource>();
        Debug.Log("pressed");
        _audioSource.clip = switchOn;
        _audioSource.Play();
    }
}
