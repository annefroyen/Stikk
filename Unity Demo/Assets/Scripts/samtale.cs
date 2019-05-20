using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class samtale : MonoBehaviour
{
    public Button rettKnapp;
    public Button rett1Knapp;
    public Button rett2Knapp;
    public Button rett3Knapp;
    public Button rett4Knapp;
    public Button rett5Knapp;
    public Button feilKnapp;
    public Button feil1Knapp;
    public Button feil2Knapp;

    public Button neste;

    public Text text;
    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

        rettKnapp.onClick.AddListener(rettKlikket);
        rett1Knapp.onClick.AddListener(rettKlikket);
        rett2Knapp.onClick.AddListener(rettKlikket);
        rett3Knapp.onClick.AddListener(rettKlikket);
        rett4Knapp.onClick.AddListener(rettKlikket);
        rett5Knapp.onClick.AddListener(rettKlikket);
        feilKnapp.onClick.AddListener(feilKlikket);
        feil1Knapp.onClick.AddListener(feil1Klikket);
        feil2Knapp.onClick.AddListener(feil2Klikket);

        GaaVidere();

        neste.interactable = false;


    }


    // Update is called once per frame
    void Update()
    {

    }

    public void rettKlikket()
    {
        score++;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }

    public void rett1Klikket()
    {
        score++;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }

    public void rett2Klikket()
    {
        score++;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }

    public void rett3Klikket()
    {
        score++;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }

    public void rett4Klikket()
    {
        score++;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }

    public void rett5Klikket()
    {
        score++;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }


    public void feilKlikket()
    {
        score--;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }

    public void feil1Klikket()
    {
        score--;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }

    public void feil2Klikket()
    {
        score--;
        if (scoreText != null)
        {
            GaaVidere();
            scoreText.text = "Current Points" + score.ToString();
        }
    }


    //kan gå vidare bare dersom man får minst 4 rette feks.
    public void GaaVidere()
    {
        //neste.interactable = false;
        if (score >= 4)
        {
            PlayerPrefs.SetInt("Spillscore", 4);
            neste.interactable = true;
            //condition for working button

        }
    }

}
