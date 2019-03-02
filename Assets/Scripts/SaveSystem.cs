using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SavedPlayer(PlayerController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/savedata.bin";
        FileStream stream = new FileStream(path, FileMode.Create);

        Save_Data data = new Save_Data(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Save_Data LoadData()
    {
        string path = Application.persistentDataPath + "/savedata.bin";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Save_Data data = formatter.Deserialize(stream) as Save_Data;

            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
