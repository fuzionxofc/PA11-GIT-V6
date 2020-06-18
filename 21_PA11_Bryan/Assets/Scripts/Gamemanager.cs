using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager thismanager;
    private int scores;
    public Text txt_score;
    // Start is called before the first frame update
    void Start()
    {
        thismanager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int score)
    {
        scores += score;
        txt_score.text = "Score: " + scores;
    }
}
