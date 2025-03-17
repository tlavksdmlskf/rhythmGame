using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Note : MonoBehaviour
{
    private Player score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GameObject.Find("Manager").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -260) * Time.deltaTime);
        
        if(GetComponent<RectTransform>().anchoredPosition.y <= -235)
        {
            score.combo = 0;
            Destroy(gameObject);
        }
    }
}
