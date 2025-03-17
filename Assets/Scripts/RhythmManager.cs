using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;

public class RhythmManager : MonoBehaviour
{
    float currentTime;
    [SerializeField] private GameObject notePrefab;
    [SerializeField] private Transform GameUI;
    
    private NoteLoader noteLoader;

    void Start()
    {
        noteLoader = GetComponent<NoteLoader>();
        InvokeRepeating("SpawnNote", 0, 0.7f);
        
    }


    void SpawnNote()
    {
        GameObject noteObj = new GameObject("Note");
        noteObj.tag = "Note";
        noteObj.transform.SetParent(GameUI);
        Note note = noteObj.AddComponent<Note>();
        Image img = noteObj.AddComponent<Image>();

        RectTransform rect = noteObj.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(65, 30);
        rect.anchoredPosition = new Vector2(-97.5f + (65 * (Random.Range(1, 5) - 1)), 255);
        //foreach (NoteData noteData in noteLoader.noteMap.notes)
        //{
        //    /*Vector2 spawnPos = new Vector2(-97.5f + (65 * (noteData.lane - 1)), 246 + 25 * noteData.time);
        //    Instantiate(notePrefab, spawnPos, Quaternion.identity, GameUI);*/

        //}
    }

    
}
