using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{

    public Text poengTekst;

    public Button rettKnapp;
    public Button feilEnKnapp;
    public Button feilToKnapp;

    public AudioSource feilTone;
    public AudioSource rettTone;

    public Image poengPanel;

    private bool nyRett;
    private bool nyFeil;

    public string nesteScene;

    void Start()
    {
        nyRett = false;
        nyFeil = false;
        feilEnKnapp.onClick.AddListener(FeilEnKlikket);
        feilToKnapp.onClick.AddListener(FeilToKlikket);
        rettKnapp.onClick.AddListener(RettKlikket);
    }
    
    void Update()
    {
        poengTekst.text = PlayerPrefs.GetInt("Spillscore").ToString();
        StartCoroutine(poengFarge());
        StartCoroutine(ventPaaNesteScene(nesteScene));
    }


    public void FeilEnKlikket()
    {
        PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
        nyFeil = true;
        feilTone.Play();
    }

    public void FeilToKlikket()
    {
        PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
        nyFeil = true;
        feilTone.Play();
    }

    public void RettKlikket()
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

    public IEnumerator ventPaaNesteScene(string scene)
    {

        if (nyRett)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(scene);
        }


    }

}
