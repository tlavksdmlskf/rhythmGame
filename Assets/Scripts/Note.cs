using UnityEngine;

public class Note : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -1));
        
        if(transform.position.y <= -235)
            Destroy(gameObject);
    }
}
