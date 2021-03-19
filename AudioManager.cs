using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    private void Start()
    {
        Play("Bg");
    }

    private void Awake()
    {

        if(instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);



        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
            s.source.loop = s.Loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound" + name + "not found Uff typo again");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Stop Sound" + name + "not found Uff typo again");
            return;
        }
        s.source.Stop();
    }

    public void Mute()
    {
        foreach (Sound s in sounds)
        {
            s.source.volume = 0f;
            s.source.pitch = 0f;
        }
    }

    public void UnMute()
    {
        foreach (Sound s in sounds)
        {
            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
        }
    }
}
