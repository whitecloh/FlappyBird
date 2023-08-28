using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;

    private void Start()
    {
        if (PlayerPrefs.HasKey("_volumeDuration"))
        {
            _audioSource.volume = PlayerPrefs.GetInt("_volumeDuration") / 150f;
        }
    }
}
