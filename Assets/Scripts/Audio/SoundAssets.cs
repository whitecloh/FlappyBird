using System;
using UnityEngine;

public class SoundAssets : MonoBehaviour
{
    private static SoundAssets instance;
    public static SoundAssets Instance => instance;

    public SoundAudioCLip[] soundAudioClipArray;


    private void Awake()
    {
        instance = this;
    }

    [Serializable]
    public class SoundAudioCLip
    {
        public Sound sound;
        public AudioClip audioClip;
    }
}

