using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class BinarySave : MonoBehaviour

{
    public string fileName = "file name";
    public string folderName = "Folder name";

    public PlayerInfo playerInfo;



    public void saveToFile(healthSystem health)
    {
        if (!Directory.Exists(folderName))

            Directory.CreateDirectory(folderName);

        BinaryFormatter formatter = new BinaryFormatter();

        FileStream saveFile = File.Create(folderName + "/" + fileName + ".bin");

        formatter.Serialize(saveFile, health);

        saveFile.Close();

        print(Directory.GetCurrentDirectory().ToString());
    }
}
