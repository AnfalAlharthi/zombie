using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Load : MonoBehaviour
{
    public string fileName = "file name";
    public string folderName = "Folder name";
    healthSystem healthsystem;
    public GameHandler gh;

    public void LoadData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open(folderName + "/" + fileName + ".bin", FileMode.Open);
        healthsystem = (healthSystem)formatter.Deserialize(saveFile);
        print(healthsystem.gethealth());

        saveFile.Close();
        gh.Loading();
    }

    internal healthSystem gethealth()
    {
        throw new NotImplementedException();
    }
    public healthSystem GetHealthSystem()
    {
        return healthsystem;
    }

}