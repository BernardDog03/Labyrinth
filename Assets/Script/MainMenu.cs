using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    
    [SerializeField] AudioManager audioManager;
    [SerializeField] Toggle muteToggle;
    [SerializeField] Slider bgmSlider;
    [SerializeField] Slider sfxSlider;
    [SerializeField] TMP_Text bgmVolumeTxt;
    [SerializeField] TMP_Text sfxVolumeTxt;
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OnEnable()
    {
        muteToggle.isOn = audioManager.IsMute;
        bgmSlider.value = audioManager.VolumeBGM;
        sfxSlider.value = audioManager.VolumeSFX;
        setBGMVolText(bgmSlider.value);
        setSFXVolText(sfxSlider.value);

    }
    public void setBGMVolText(float value)
    {
        bgmVolumeTxt.text = Mathf.RoundToInt(value * 100).ToString();
    }
    public void setSFXVolText(float value)
    {
        sfxVolumeTxt.text = Mathf.RoundToInt(value * 100).ToString();
    }
}
