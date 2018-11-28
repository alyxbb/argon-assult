using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour {

   

    int score;
    Text scoretext;
    
    // Use this for initialization
	void Start () {
        scoretext = GetComponent<Text>();
        scoretext.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScoreHit(int scoreincrease)
    {
        score = score + scoreincrease;
        scoretext.text = score.ToString();
    }
}
