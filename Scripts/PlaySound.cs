using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float volume;
    AudioSource audio;
    public bool alreadyplayed = false;
    AudioSource audioSource;
    void Start()
    {
        audio = GetComponent<AudioSource>();   
    }

    void Update()
    {
        if (alreadyplayed == true && audio.isPlaying == false)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (!alreadyplayed)
        {
            audio.PlayOneShot(SoundToPlay, volume);
            alreadyplayed = true;
        }
    }

}
