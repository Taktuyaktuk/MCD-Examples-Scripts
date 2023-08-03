using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
//using UnityEngine.Rendering.Universal;
using TMPro;
using UnityEngine.UI;

public class QualitySettingsScript : MonoBehaviour
{
    //    public RenderPipelineAsset[] QualityLevels;

    //    [SerializeField] private TMP_Dropdown _dropdown;
    //    [SerializeField] private Toggle _toggleFPS;
    //    [SerializeField] private Toggle _togglePostProcessing;
    //    [SerializeField] private Toggle _toggleMute;
    //    [SerializeField] private Toggle _toggleVibrationOff;
    //    [SerializeField] private Slider _volumeSlider;
    //    [SerializeField] private MixerController _audioMixerControler;
    //    [SerializeField] private AudioSource _audioSource;
    //    [SerializeField] Image _sliderHandle;

    //    private void Start()
    //    {
    //        _dropdown.value = QualitySettings.GetQualityLevel();
    //        VolumeSliderOnStart();
    //        FPSToggleManager();
    //        MuteTogleManager();
    //        VibrationOffToogleManager();
    //        PostProcessingOnAwake();
    //        PostProcessingToggleManager();
    //    }

    //    public void ChangeQualityLevel(int value)
    //    {
    //        QualitySettings.SetQualityLevel(value);
    //        QualitySettings.renderPipeline = QualityLevels[value];
    //    }

    //    public void FPSToggle()
    //    {
    //        if (_toggleFPS.isOn)
    //        {
    //            PlayerPrefs.SetInt("FPSCounter", 1);
    //        }
    //        else
    //        {
    //            PlayerPrefs.SetInt("FPSCounter", 0);
    //        }
    //    }

    //    public void VibrationOffToogle()
    //    {
    //        if(_toggleVibrationOff.isOn)
    //        {
    //            PlayerPrefs.SetInt("VibrationSettings", 1);
    //        }
    //        else
    //        {
    //            PlayerPrefs.SetInt("VibrationSettings", 0);
    //        }   
    //    }

    //    public void PostProcessingToggle()
    //    {
    //        if(_togglePostProcessing.isOn)
    //        {
    //            PlayerPrefs.SetInt("PostProcessing", 1);
    //        }
    //        else
    //        {
    //            PlayerPrefs.SetInt("PostProcessing", 0);
    //        }
    //    }

    //    private void VibrationOffToogleManager()
    //    {
    //        int VibrationOffDisplayStatus = PlayerPrefs.GetInt("VibrationSettings");
    //        if(VibrationOffDisplayStatus == 1)
    //        {
    //            _toggleVibrationOff.isOn = true;
    //        }
    //        else
    //        {
    //            _toggleVibrationOff.isOn = false;
    //        }
    //    }
    //    private void PostProcessingToggleManager()
    //    {
    //        int PostProcessingDisplayStatus = PlayerPrefs.GetInt("PostProcessing");
    //        if(PostProcessingDisplayStatus == 1)
    //        {
    //            _togglePostProcessing.isOn = true;
    //        }
    //        else
    //        {
    //            _togglePostProcessing.isOn = false;
    //        }
    //    }
    //    private void FPSToggleManager()
    //    {
    //        int FPSDisplayStatus = PlayerPrefs.GetInt("FPSCounter");
    //        if(FPSDisplayStatus == 1)
    //        {
    //            _toggleFPS.isOn = true;
    //        }
    //        else
    //        {
    //            _toggleFPS.isOn = false;
    //        }
    //    }
    //    public void MuteToggle()
    //    {
    //        if(_toggleMute.isOn)
    //        {
    //            _volumeSlider.value = 0;
    //            _volumeSlider.interactable = false;
    //            _sliderHandle.color = new Color32(140, 140, 140, 255);
    //        }
    //        else if(!_toggleMute.isOn)
    //        {
    //            _volumeSlider.interactable = true;
    //            _volumeSlider.value = 0.5f;
    //            _sliderHandle.color = new Color32(11, 21, 30, 255);
    //        }
    //    }

    //    private void MuteTogleManager()
    //    {
    //        int MuteToogleStatus = PlayerPrefs.GetInt("MuteCounter");
    //        if(MuteToogleStatus == 1)
    //        {
    //            _toggleMute.isOn = true;
    //            _audioSource.mute = true;
    //        }
    //        else if (MuteToogleStatus == 0)
    //        {
    //            _toggleMute.isOn = false;
    //            _audioSource.mute = false;
    //        }
    //    }

    //    public void VolumeSliderActualValue()
    //    {
    //        var value = _volumeSlider.value;
    //        PlayerPrefs.SetFloat("VolumeSlider", value);
    //    }
    //    private void VolumeSliderOnStart()
    //    {
    //        if (PlayerPrefs.HasKey("VolumeSlider"))
    //        {
    //            _volumeSlider.value = PlayerPrefs.GetFloat("VolumeSlider");
    //        }
    //        else
    //        {
    //            _volumeSlider.value = 1f;
    //        }
    //    }

    //    private void PostProcessingOnAwake()
    //    {
    //        if(PlayerPrefs.HasKey("PostProcessing") == false)
    //        {
    //            PlayerPrefs.SetInt("PostProcessing", 0);
    //        }
    //    }
}
