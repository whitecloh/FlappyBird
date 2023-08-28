using System;
using UnityEngine;

public class SoundManager:MonoBehaviour
    {
    private static SoundManager instance;
    public static SoundManager Instance => instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(Sound sound)
    {
        GameObject gO = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gO.GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("_volumeDuration"))
        {
            audioSource.volume = PlayerPrefs.GetInt("_volumeDuration") / 100f;
        }
        audioSource.PlayOneShot(GetAudioClip(sound));
        Destroy(gO,2f);
    }

    private AudioClip GetAudioClip(Sound sound)
    {
        foreach(SoundAssets.SoundAudioCLip soundAudioCLip in SoundAssets.Instance.soundAudioClipArray)
        {
            if(soundAudioCLip.sound==sound)
            {
                return soundAudioCLip.audioClip;
            }
        }
        return null;
    }
}

public enum Sound
{
    BirdJump,
    Score,
    GameOver,
    Hit,
    ButtonClick
}