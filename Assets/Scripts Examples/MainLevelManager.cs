using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLevelManager : MonoBehaviour
{
    //public int[] EasyLevels;
    //public int[] MediumLevels;
    //public int[] HardLevels;
    //public int[] VeryHardLevels;
    //public int[] UltraHardLevels;

    //public bool[] EasyLevelsExtraCoins;
    //public bool[] MediumLevelsExtraCoins;
    //public bool[] HardLevelsExtraCoins;
    //public bool[] VeryHardLevelsExtraCoins;
    //public bool[] UltraHardLevelsExtraCoins;

    //public bool[] Stickers;
    //public bool[] SteeringWheels;
    //public bool[] Pedals;
    //public bool[] GearBoxes;

    //public int Coins;
    //public int SkipsAmount;
    //public bool AdsDisabled;

    //public float[] EasyRecords;
    //public float[] MediumRecords;
    //public float[] HardRecords;
    //public float[] VeryHardRecords;
    //public float[] UltraRecords;

    //private void Awake()
    //{
    //    LoadPlayerData();

    //    if(Stickers[0] == false)
    //    {
    //        Stickers[0] = true;
    //    }
    //    if(SteeringWheels[0] == false)
    //    {
    //        SteeringWheels[0] = true;
    //    }
    //    if(Pedals[0] == false)
    //    {
    //        Pedals[0] = true;
    //    }
    //    if(GearBoxes[0] == false)
    //    {
    //        GearBoxes[0] = true;
    //    }
    //}

    //public void LevelUnlock(string dificulty ,int levelNumber)
    //{
    //    levelNumber -= 1;

    //    switch (dificulty) 
    //    {
    //        case "Easy":
    //            EasyLevels[levelNumber] = 1;
    //            break;
    //        case "Medium":
    //            MediumLevels[levelNumber] = 1;
    //            break;
    //        case "Hard":
    //            HardLevels[levelNumber] = 1;
    //            break;
    //        case "VeryHard":
    //            VeryHardLevels[levelNumber] = 1;
    //            break;
    //        case "UltraHard":
    //            UltraHardLevels[levelNumber] = 1;
    //            break;
    //        default:
    //            Debug.Log("Upsss...Something goes wrong");
    //            break;
    //    }
    //}

    //public void ExtraCoinsUnlock(string dificulty, int levelNumber)
    //{
    //    switch (dificulty)
    //    {
    //        case "Easy":
    //            EasyLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        case "Medium":
    //            MediumLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        case "Hard":
    //            HardLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        case "VeryHard":
    //            VeryHardLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        case "UltraHard":
    //            UltraHardLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        default:
    //            Debug.Log("Upsss...Something goes wrong");
    //                break;
    //    }
    //}

    //public void Records(string dificulty, int levelNumber, float endedLapTime)
    //{
    //    switch (dificulty)
    //    {
    //        case "Easy":
    //            if (EasyRecords[levelNumber] > 0)
    //            {
    //                if (endedLapTime < EasyRecords[levelNumber])
    //                {
    //                    EasyRecords[levelNumber] = endedLapTime;
    //                }
    //            }
    //            else
    //            {
    //                EasyRecords[levelNumber] = endedLapTime;
    //            }
    //            break;
    //        case "Medium":
    //            MediumLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        case "Hard":
    //            HardLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        case "VeryHard":
    //            VeryHardLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        case "UltraHard":
    //            UltraHardLevelsExtraCoins[levelNumber] = true;
    //            break;
    //        default:
    //            Debug.Log("Upsss...Something goes wrong");
    //            break;
    //    }
    //}

    //public void SavePlayerData()
    //{
    //    SaveSystem.SavePlayer(this);
    //}

    //public void LoadPlayerData()
    //{
    //    PlayerData data = SaveSystem.LoadPlayer();

    //    EasyLevels = data.EasyLevels;
    //    MediumLevels = data.MediumLevels;
    //    HardLevels = data.HardLevels;
    //    VeryHardLevels = data.VeryHardLevels;
    //    UltraHardLevels = data.UltraHardLevels;

    //    EasyLevelsExtraCoins = data.EasyLevelsExtraCoins;
    //    MediumLevelsExtraCoins = data.MediumLevelsExtraCoins;
    //    HardLevelsExtraCoins = data.HardLevelsExtraCoins;
    //    VeryHardLevelsExtraCoins = data.VeryHardLevelsExtraCoins;
    //    UltraHardLevelsExtraCoins = data.UltraHardLevelsExtraCoins;

    //    Stickers = data.Stickers;
    //    SteeringWheels = data.SteeringWheels;
    //    Pedals = data.Pedals;
    //    GearBoxes = data.GearBoxes;

    //    Coins = data.Coins;
    //    SkipsAmount = data.SkipsAmount;
    //    AdsDisabled = data.AdsDisabled;
    //}

    //public void StickerUnlock(int stickerNumber)
    //{
    //    Stickers[stickerNumber] = true;
    //    SaveSystem.SavePlayer(this);
    //}

    //public void SteeringWheelUnlock(int steeringWheelNr)
    //{
    //    SteeringWheels[steeringWheelNr] = true;
    //    SaveSystem.SavePlayer(this);
    //}

    //public void PedalsUnlock(int PedalsNumber)
    //{
    //    Pedals[PedalsNumber] = true;
    //    SaveSystem.SavePlayer(this);
    //}

    //public void GearBoxUnlock(int GearBoxNumber)
    //{
    //    GearBoxes[GearBoxNumber] = true;
    //    SaveSystem.SavePlayer(this);
    //}

    //public void Skip()
    //{
    //    if (SkipsAmount >= 1)
    //    {
    //        SkipsAmount -= 1;
    //    }
    //}

    //public void RandomCoins()
    //{
    //    var randomCoins = Random.Range(1, 20);
    //    Coins = Coins + randomCoins;
    //}
}
