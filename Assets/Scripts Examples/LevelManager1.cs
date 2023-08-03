using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager1 : MonoBehaviour
{
    //    public string LevelDifficult;

    //    [SerializeField] private GameObject _levels;
    //    [SerializeField] private Toggle[] _allLeveles;
    //    [SerializeField] private ToggleGroup _toggleGroup;
    //    [SerializeField] private MainLevelManager _mainLevelManager;

    //    private string _actualButtonPressed;

    //    private void Awake()
    //    {
    //        _allLeveles = _levels.GetComponentsInChildren<Toggle>();
    //    }

    //    private void Start()
    //    {
    //        _mainLevelManager = GameObject.Find("MainLevelManager").GetComponent<MainLevelManager>();
    //        LastChosenLevel();
    //        LevelChecker();
    //        StartCoroutine(ToggleOffEndFrame());

    //    }

    //    private void LevelChecker()
    //    {
    //        switch (LevelDifficult)
    //        {
    //            case "Easy":

    //        for (int i = 1; i < _allLeveles.Length; i++)
    //        {

    //            if (_mainLevelManager.EasyLevels[i] >= 1)
    //            {
    //                _allLeveles[i].interactable = true;
    //                _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(6, 165, 255, 255);
    //            }
    //            else
    //            {
    //                _allLeveles[i].interactable = false;
    //                _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(197, 197, 197, 255);
    //            }
    //        }
    //        break;

    //            case "Medium":
    //                for (int i = 1; i < _allLeveles.Length; i++)
    //                {

    //                    if (_mainLevelManager.MediumLevels [i] >= 1)
    //                    {
    //                        _allLeveles[i].interactable = true;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(6, 165, 255, 255);
    //                    }
    //                    else
    //                    {
    //                        _allLeveles[i].interactable = false;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(197, 197, 197, 255);
    //                    }
    //                }
    //                break;

    //            case "Hard":
    //                for (int i = 1; i < _allLeveles.Length; i++)
    //                {

    //                    if (_mainLevelManager.HardLevels[i] >= 1)
    //                    {
    //                        _allLeveles[i].interactable = true;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(6, 165, 255, 255);
    //                    }
    //                    else
    //                    {
    //                        _allLeveles[i].interactable = false;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(197, 197, 197, 255);
    //                    }
    //                }
    //                break;

    //            case "VeryHard":
    //                for (int i = 1; i < _allLeveles.Length; i++)
    //                {
    //                    var name = _allLeveles[i - 1].name;

    //                    if (_mainLevelManager.VeryHardLevels [i] >= 1)
    //                    {
    //                        _allLeveles[i].interactable = true;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(6, 165, 255, 255);
    //                    }
    //                    else
    //                    {
    //                        _allLeveles[i].interactable = false;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(197, 197, 197, 255);
    //                    }
    //                }
    //                break;

    //            case "UltraHard":
    //                for (int i = 1; i < _allLeveles.Length; i++)
    //                {
    //                    var name = _allLeveles[i - 1].name;

    //                    if (_mainLevelManager.UltraHardLevels[i] >= 1)
    //                    {
    //                        _allLeveles[i].interactable = true;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(6, 165, 255, 255);
    //                    }
    //                    else
    //                    {
    //                        _allLeveles[i].interactable = false;
    //                        _allLeveles[i].GetComponentInChildren<Image>().color = new Color32(197, 197, 197, 255);
    //                    }
    //                }
    //                break;

    //            default:
    //                Debug.Log("Ups... Wrong LevelDifficulty input");
    //                break;

    //        }
    //    }

    //    private void ToggleGroupIfSwitchOff()
    //    {
    //        if (_toggleGroup.allowSwitchOff == true)
    //        {
    //            _toggleGroup.allowSwitchOff = false;
    //        }
    //    }
    //    public void LevelClicked(Toggle button)
    //    {
    //        _actualButtonPressed = button.GetComponent<Toggle>().name;
    //        PlayerPrefs.SetString("ActualScene", "Level" + LevelDifficult + _actualButtonPressed);
    //        PlayerPrefs.SetString("Button" + LevelDifficult + "Pressed", _actualButtonPressed);
    //    }

    //    private void LastChosenLevel()
    //    {
    //        if (!PlayerPrefs.HasKey("Button" + LevelDifficult + "Pressed"))
    //        {
    //            PlayerPrefs.SetString("Button" + LevelDifficult + "Pressed", "1");
    //            _allLeveles[0].isOn = true;
    //            Debug.Log("BEzPRefs!");
    //        }
    //        else
    //        {
    //            var a = int.Parse(PlayerPrefs.GetString("Button" + LevelDifficult + "Pressed"));
    //            _allLeveles[a - 1].isOn = true;
    //        }
    //    }


    //    public void ContinueButton()
    //    {
    //        if (PlayerPrefs.HasKey("Button" + LevelDifficult + "Pressed"))
    //        {
    //            if (_actualButtonPressed != null)
    //            {
    //                SceneManager.LoadScene("Level" + LevelDifficult + PlayerPrefs.GetString("Button" + LevelDifficult + "Pressed"));
    //            }
    //            else
    //            {
    //                SceneManager.LoadScene("Level" + LevelDifficult + PlayerPrefs.GetString("ButtonPressed"));
    //            }
    //        }
    //        else
    //        {
    //            SceneManager.LoadScene("Level" + LevelDifficult + "1");
    //        } 
    //    }

    //    IEnumerator ToggleOffEndFrame()
    //    {
    //        yield return new WaitForEndOfFrame();
    //        ToggleGroupIfSwitchOff();
    //        StopCoroutine("ToggleOffEndFrame");
    //    }
}
