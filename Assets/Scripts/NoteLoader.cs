using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class NoteData
{
    public float time;  
    public int lane;    
}

[System.Serializable]
public class NoteMap
{
    public float bpm;
    public List<NoteData> notes;
}
public class NoteLoader : MonoBehaviour
{
    public string fileName = "Beatmap.json"; 
    public NoteMap noteMap;

    void Awake()
    {
        string path = Path.Combine(Application.streamingAssetsPath, fileName);
        string jsonData = File.ReadAllText(path);
        noteMap = JsonUtility.FromJson<NoteMap>(jsonData);
    }
}
