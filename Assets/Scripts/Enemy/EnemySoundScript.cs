using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoundScript : MonoBehaviour
{
    public AudioClip RocketFired;
    public AudioSource RocketSoundSource;


    // Start is called before the first frame update
    void Start()
    {
        RocketSoundSource.clip = RocketFired;
    }

    public void FireRocketSound()
    {
        RocketSoundSource.Play();
    }
}
