using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public Text hsTekst;
    public Text ssTekst;
    int highscore;
    int spillscore;


    // Start is called before the first frame update
    void Start()
    {
        if (spillscore > highscore)
        {
            PlayerPrefs.SetInt("Highscore", spillscore);
        }
        highscore = PlayerPrefs.GetInt("Highscore");
        spillscore = PlayerPrefs.GetInt("Spillscore");
        hsTekst.text = highscore.ToString();
        ssTekst.text = spillscore.ToString();

        
    }

    // Update is called once per frame
    void Update()
    {
    }
     
}
