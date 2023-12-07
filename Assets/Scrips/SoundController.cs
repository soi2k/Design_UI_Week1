using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private static SoundController buttonSound;
    public static SoundController ButtonSound { get => buttonSound; }

    private void Awake()
    {
        if(buttonSound == null)
        {
            buttonSound = this;
        }
    }

    public void ButtonPlaySound(string soundName, float volumMultiplier)
    {
        AudioSource audiosource = this.gameObject.AddComponent<AudioSource>();
        audiosource.volume *= volumMultiplier;
        audiosource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + soundName, typeof(AudioClip)));
    }
}
