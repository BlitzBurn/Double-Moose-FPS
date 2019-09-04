using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoxSounds : MonoBehaviour
{
    public AudioClip ammoPickUpSoundEffect;
    public AudioSource ammoPickUpSoundSource;

    void Start()
    {
        ammoPickUpSoundSource.clip = ammoPickUpSoundEffect;
    }

    public void PlayAmmoSound()
    {
        ammoPickUpSoundSource.Play();
    }
}
