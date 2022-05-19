using System;
using UnityEngine;

public class FBPPConfig
{
    private const string DEFAULT_SAVE_FILE_NAME = "saveData.txt";
    private const string DEFAULT_ENCRYPTION_SECRET = "encryption-secret-default";

    public string SaveFileName = DEFAULT_SAVE_FILE_NAME;

    public bool AutoSaveData = true;

    public bool ScrambleSaveData = true;

    public string EncryptionSecret = DEFAULT_ENCRYPTION_SECRET;

    public string SaveFilePath = null;

    public Action OnLoadError;

    internal string windows_GetSaveFilePath()
    {
        return string.IsNullOrEmpty(SaveFilePath) ? Application.windows_persistentDataPath : SaveFilePath;
    }
    internal string parallels_GetSaveFilePath()
    {
        return string.IsNullOrEmpty(SaveFilePath) ? Application.parallels_persistentDataPath : SaveFilePath;
    }

}
