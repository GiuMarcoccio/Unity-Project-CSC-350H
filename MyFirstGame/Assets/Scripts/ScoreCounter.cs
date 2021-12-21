using UnityEngine.UI;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int score { get; set; }

    void Start()
    {
        gameObject.GetComponent<Text>().text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        gameObject.GetComponent<Text>().text = "Score:\t" + score;
    }
}
