using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : BaseManager
{
    public AudioClip mainTheme;
    public AudioClip planetCraftTheme;
    public AudioClip[] voxAlien1;

    public AudioSource mainAudioSource;
    public AudioSource audioSourceVoxAlien1;

    void Update()
    {
        // Not really the best place but it's good for now,
        // we want to stop the crafting, when the song is
        // done we say it to the game manager.

    }

    // Start is called before the first frame update
    void Start()
    {
        // This is the very first sound that we want to load my friend!
        // So just play it with a loop. We'll break this main theme later,
        // when the player will start to craft its planet!
        mainAudioSource.clip = mainTheme;
        mainAudioSource.loop = true;
        mainAudioSource.Play();
    }

    public void PlayPlanetCraft()
    {
        mainAudioSource.clip = planetCraftTheme;
        mainAudioSource.loop = false;
        mainAudioSource.Play();
    }

    public void PlayVoiceAlien1()
    {
        int idx = Random.Range(0, voxAlien1.Length);

        audioSourceVoxAlien1.clip = voxAlien1[idx];
        audioSourceVoxAlien1.Play();
    }
}
