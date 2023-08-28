using UnityEngine;
using UnityEngine.UI;

public class SaveSettings : MonoBehaviour
{
    [SerializeField]
    private Slider _volumeSlider;
    [SerializeField]
    private Dropdown _gameMode;

    private int _volumeDuration;
    private int _modeNumber;

    void Awake()
    {
        LoadParams();
    }

    void Update()
    {
        VolumeValue();
        SaveParams();
    }

    private void VolumeValue()
    {
        _volumeDuration = (int)_volumeSlider.value;
        _modeNumber = _gameMode.value;
    }
    private void SaveParams()
    {
        PlayerPrefs.SetInt("_volumeDuration", _volumeDuration);
        PlayerPrefs.SetInt("_modeNumber", _modeNumber);
        PlayerPrefs.Save();
    }
    private void LoadParams()
    {
        if (PlayerPrefs.HasKey("_volumeDuration"))
        {
            _volumeDuration = PlayerPrefs.GetInt("_volumeDuration");
        }
        if (PlayerPrefs.HasKey("_modeNumber"))
        {
            _modeNumber = PlayerPrefs.GetInt("_modeNumber");
        }

        _volumeSlider.value = _volumeDuration;
        _gameMode.value = _modeNumber;

    }
}
