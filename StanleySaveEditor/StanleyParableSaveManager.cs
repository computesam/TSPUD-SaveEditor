using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace StanleySaveEditor
{
    public class StanleyParableSaveContainer
    {
        public FBPPFileModel saveDataMisc;
        public StanleyParableSave saveData;

        public void WindowsSave()
        {
            string JsonSave = JsonConvert.SerializeObject(saveData, Formatting.Indented);
            saveDataMisc.UpdateOrAddData("data", JsonSave);
            string coreSaveAsJson = JsonConvert.SerializeObject(saveDataMisc, Formatting.None);
            var saveFileText = StanleyParableSaveManager.Unscramble(coreSaveAsJson);
            string WindowsSaveFileJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "Crows Crows Crows", "The Stanley Parable_ Ultra Deluxe", "tspud-savedata.txt");

            File.WriteAllText(WindowsSaveFileJson, saveFileText);
        }
        public void ParallelsSave()
        {
            string JsonSave = JsonConvert.SerializeObject(saveData, Formatting.Indented);
            saveDataMisc.UpdateOrAddData("data", JsonSave);
            string coreSaveAsJson = JsonConvert.SerializeObject(saveDataMisc, Formatting.None);
            var saveFileText = StanleyParableSaveManager.Unscramble(coreSaveAsJson);
            string WindowsSaveFileJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer), "Y:", "Library", "Application Support", "com.crowscrowscrows.thestanleyparableultradeluxe", "tspud-savedata.txt");

            File.WriteAllText(WindowsSaveFileJson, saveFileText);
        }

    }

    public class StanleyParableSaveManager
    {
        public static readonly string Key = "saRpmZ6mMgZpmcojUkvkyGEQGez9YkWoXZfJdRc9ZmmJrCzfM8JksVxQfQK8uBBs";
        public static readonly string WindowsSaveFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "Crows Crows Crows", "The Stanley Parable_ Ultra Deluxe", "tspud-savedata.txt");
        public static readonly string ParallelsSaveFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer), "Y:", "Library", "Application Support", "com.crowscrowscrows.thestanleyparableultradeluxe", "tspud-savedata.txt");
        public static readonly string WindowsSaveFileJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "Crows Crows Crows", "The Stanley Parable_ Ultra Deluxe", "tspud-savedata.json");
        public static readonly string ParallelsSaveFileJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer), "Y:", "Library", "Application Support", "com.crowscrowscrows.thestanleyparableultradeluxe", "tspud-savedata.json");


        public static StanleyParableSaveContainer Windows_LoadSaveToMemory()
        {
            var saveFileText = File.ReadAllText(WindowsSaveFile);
            saveFileText = Unscramble(saveFileText);
            File.WriteAllText(WindowsSaveFileJson, saveFileText);

            var saveRoot = JsonConvert.DeserializeObject<FBPPFileModel>(saveFileText);
            var saveData = JsonConvert.DeserializeObject<StanleyParableSave>((string)saveRoot.GetValueForKey("data", "{\n    \"saveDataCache\": []\n}"));

            StanleyParableSaveContainer containerRoot = new StanleyParableSaveContainer();
            containerRoot.saveDataMisc = saveRoot;
            containerRoot.saveData = saveData;

            return containerRoot;
        }
        public static StanleyParableSaveContainer Parallels_LoadSaveToMemory()
        {
            var saveFileText = File.ReadAllText(ParallelsSaveFile);
            saveFileText = Unscramble(saveFileText);
            File.WriteAllText(ParallelsSaveFileJson, saveFileText);

            var saveRoot = JsonConvert.DeserializeObject<FBPPFileModel>(saveFileText);
            var saveData = JsonConvert.DeserializeObject<StanleyParableSave>((string)saveRoot.GetValueForKey("data", "{\n    \"saveDataCache\": []\n}"));

            StanleyParableSaveContainer containerRoot = new StanleyParableSaveContainer();
            containerRoot.saveDataMisc = saveRoot;
            containerRoot.saveData = saveData;

            return containerRoot;
        }


        static StringBuilder _sb = new StringBuilder();

        internal static string Unscramble(string data)
        {
            _sb.Clear();

            for (int i = 0; i < data.Length; i++)
            {
                _sb.Append((char)(data[i] ^ Key[i % Key.Length]));
            }
            return _sb.ToString();
        }
    }
}
