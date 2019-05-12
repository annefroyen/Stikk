using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Håndhygiene : MonoBehaviour
{

    public Text poengTekst;

    public Button FemtenKnapp;
    public Button TrettiKnapp;
    public Button MinuttKnapp;

    public AudioSource feilTone;
    public AudioSource rettTone;

    public Image poengPanel;

    private bool nyRett;
    private bool nyFeil;

    void Start()
    {
        nyRett = false;
        nyFeil = false;
        FemtenKnapp.onClick.AddListener(FemtenKlikket);
        TrettiKnapp.onClick.AddListener(TrettiKlikket);
        MinuttKnapp.onClick.AddListener(MinuttKlikket);
    }
    
    void Update()
    {
        poengTekst.text = PlayerPrefs.GetInt("Spillscore").ToString();
        StartCoroutine(poengFarge());
        StartCoroutine(ventPaaNesteScene());
    }


    public void FemtenKlikket()
    {
        PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
        nyFeil = true;
        feilTone.Play();
    }

    public void TrettiKlikket()
    {
        PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
        nyFeil = true;
        feilTone.Play();
    }

    public void MinuttKlikket()
    {
        PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
        nyRett = true;
        rettTone.Play();
        
    }


    private IEnumerator poengFarge()
    {
        if (nyRett)
        {
           
            poengPanel.color = Color.green;
            yield return new WaitForSeconds(1);
            poengPanel.color = Color.white;
            nyRett = false;

        }

        if (nyFeil)
        {
            
            poengPanel.color = Color.red;
            yield return new WaitForSeconds(1);
            poengPanel.color = Color.white;
            nyFeil = false;
        }
    }

    private IEnumerator ventPaaNesteScene()
    {

        if (nyRett)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("Rekvisisjon");
        }


    }

}
