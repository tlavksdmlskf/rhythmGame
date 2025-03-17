using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Player score;
    public TextMeshProUGUI text;
    void Start()
    {
        score = GameObject.Find("Manager").GetComponent<Player>();
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = text.text.Substring(0, 8) + score.combo;
    }
}
