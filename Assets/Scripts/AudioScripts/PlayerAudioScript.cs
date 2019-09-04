using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioScript : MonoBehaviour
{
    public AudioClip weaponFireSoundEffect;
    public AudioClip stormFireSoundEffect;
    public AudioClip jumpSoundEffect;
    public AudioClip ammoPickUpSoundEffect;

    public AudioSource weaponFireSource;
    public AudioSource stormFireSoundSource;
    //public AudioSource jumpSoundSource;
    public AudioSource ammoPickUpSoundSource;

    void Start()
    {
        weaponFireSource.clip = weaponFireSoundEffect;
        stormFireSoundSource.clip = stormFireSoundEffect;
       // jumpSoundSource.clip = jumpSoundEffect;
        ammoPickUpSoundSource.clip = ammoPickUpSoundEffect;
    }

    public void PlayWeaponSound()
    {
        Debug.Log("fire");
        weaponFireSource.Play();
    }

    public void PlayStormFireSound()
    {
        stormFireSoundSource.Play();
    }

    public void PlayJumpSound()
    {
       // jumpSoundSource.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AmmoBox")
        {
            ammoPickUpSoundSource.Play();
        }
    }

}
