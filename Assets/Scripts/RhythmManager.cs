using UnityEngine;
using System.Collections.Generic;

public class RhythmManager : MonoBehaviour
{
    float currentTime;
    [SerializeField] private GameObject notePrefab;
    [SerializeField] private Transform GameUI;
    private NoteLoader noteLoader;

    void Start()
    {
        noteLoader = GetComponent<NoteLoader>();
        SpawnNote();
    }

    void Update()
    {
        currentTime += Time.deltaTime;
    }

    void SpawnNote()
    {
        foreach (NoteData noteData in noteLoader.noteMap.notes)
        {
            Vector2 spawnPos = new Vector2(-97.5f + (65 * (noteData.lane - 1)), 246 + 25 * noteData.time);
            Instantiate(notePrefab, spawnPos, Quaternion.identity, GameUI);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.tag == "Note")
        {
            Destroy(collision.gameObject);
        }
    }
}
