using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    //    public static void SavePlayer (MainLevelManager mainLevelManager)
    //    {
    //        BinaryFormatter formater = new BinaryFormatter();
    //        string path = Application.persistentDataPath + "/playerSave.microData";
    //        FileStream stream = new FileStream(path, FileMode.Create);

    //        PlayerData data = new PlayerData(mainLevelManager);

    //        formater.Serialize(stream, data);
    //        stream.Close();
    //    }

    //    public static PlayerData LoadPlayer()
    //    {
    //        string path = Application.persistentDataPath + "/playerSave.microData";

    //        if(File.Exists(path))
    //        {
    //            BinaryFormatter formatter = new BinaryFormatter();
    //            FileStream stream = new FileStream(path, FileMode.Open);

    //            PlayerData data = formatter.Deserialize(stream) as PlayerData;
    //            stream.Close();

    //            return data;
    //        }
    //        else
    //        {
    //            return null;
    //        }
    //    }
}
