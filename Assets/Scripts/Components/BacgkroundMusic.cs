using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BacgkroundMusic : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;

    private void Start() 
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1f);
            Load();
        }
        else
        {
            Load();
        }
    }

    private void Load()
    {
        _volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", _volumeSlider.value);
    }

    public void ChangeVolume()
    {
        AudioListener.volume = _volumeSlider.value;
        Save();
    }
}
