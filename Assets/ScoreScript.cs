using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI MyScoreUI;
    public int MyScoreValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyScoreUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //AddToScore();
    }

    public void AddToScore()
    {
        MyScoreValue += 1;
        MyScoreUI.text = MyScoreValue.ToString();
    }
}
