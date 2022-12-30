using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider masterSlider, musicSlider, sfxSlider;

    public string masterString, musicString, sfxString;

    float masterValue, musicValue, sfxValue;

    private void Awake()
    {
        SetMasterVolume();
        SetMusicVolume();
        SetSfxVolume();
    }

    /// <summary>
    /// adjusts the master volume
    /// </summary>
    public void SetMasterVolume()
    {
        masterValue = masterSlider.value;
#warning adjust value to -80 and 20
        audioMixer.SetFloat(masterString, masterSlider.value);

        masterSlider.GetComponent<SliderBehaviour>().ChangeTextByValue(AdjustValue(masterValue));    
    }

    /// <summary>
    /// adjusts the music volume
    /// </summary>
    public void SetMusicVolume()
    {
        musicValue = musicSlider.value;
        audioMixer.SetFloat(musicString, musicSlider.value);

        musicSlider.GetComponent<SliderBehaviour>().ChangeTextByValue(AdjustValue(musicValue));
    }

    /// <summary>
    /// adjusts the sfx volume
    /// </summary>
    public void SetSfxVolume()
    {
        sfxValue = sfxSlider.value;
        audioMixer.SetFloat(sfxString, sfxSlider.value);

        sfxSlider.GetComponent<SliderBehaviour>().ChangeTextByValue(AdjustValue(sfxValue));
    }

    /// <summary>
    /// adjust the value for displaying in the options menu
    /// value gets multiplied by 100
    /// or if its equal to 0.0001 it will return 0
    /// </summary>
    /// <param name="value"> value to adjust </param>
    /// <returns></returns>
    int AdjustValue(float value)
    {
        Debug.Log(value);
        if (value == 0.0001f)
        {
            value = 0;
        }
        else
        {
            value += 80;
        }

        return (int)value;
    }
}
