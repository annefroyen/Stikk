using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartSide : MonoBehaviour
{

    public Text hsTekst;
    int highscore;
    public Button resetKnapp;


    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
        hsTekst.text = highscore.ToString();
        resetKnapp.onClick.AddListener(resetHighScore);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void resetHighScore()
    {
        PlayerPrefs.SetInt("Highscore", 0);
        hsTekst.text = "0";

    }

}
