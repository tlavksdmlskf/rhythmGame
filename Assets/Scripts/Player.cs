using NUnit.Framework;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int combo;
    void Update()
    {
        GameObject[] notes = GameObject.FindGameObjectsWithTag("Note");

        foreach (GameObject note in notes)
        {
            Vector3 pos = note.GetComponent<RectTransform>().anchoredPosition;

            if (Input.GetKeyUp(KeyCode.A) && IsInPosition(pos, -97.5f))
            {
                
                HandleNote(note);
            }
            else if (Input.GetKeyUp(KeyCode.S) && IsInPosition(pos, -32.5f))
            {
                
                HandleNote(note);
            }
            else if (Input.GetKeyUp(KeyCode.K) && IsInPosition(pos, 32.5f))
            {
                
                HandleNote(note);
            }
            else if (Input.GetKeyUp(KeyCode.L) && IsInPosition(pos, 97.5f))
            {
               
                HandleNote(note);
            }
            else
            {

            }
        }
    }

    bool IsInPosition(Vector3 pos, float targetX)
    {
        
        return pos.x == targetX && pos.y <= -113.5f && pos.y >= -186.5f;
    }

    void HandleNote(GameObject note)
    {
        combo++;
        Destroy(note);
        
    }
}
