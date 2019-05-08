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

        PlayerPrefs.SetInt("Spillscore", 0);
        PlayerPrefs.SetInt("LillaBrukt", 0);
        PlayerPrefs.SetInt("RødBrukt", 0);
        PlayerPrefs.SetInt("BlåBrukt", 0);
        PlayerPrefs.SetInt("GulBrukt", 0);
        PlayerPrefs.SetInt("SortBrukt", 0);
        PlayerPrefs.SetInt("GrønnBrukt", 0);
        PlayerPrefs.SetInt("KanyleBrukt", 0);
        PlayerPrefs.SetInt("DesinfeksjonBrukt", 0);
        PlayerPrefs.SetInt("StaseBrukt", 0);

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
