using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VelgRør : MonoBehaviour
{

    public Text poengTekst;
    public Image poengPanel;

    public AudioSource feilTone;
    public AudioSource rettTone;

    private bool nyRett;
    private bool nyFeil;

    public string nesteScene;

    public bool blå;
    public bool rød;
    public bool grønn;
    public bool gul;
    public bool lilla;
    public bool sort;

    public GameObject blåKnappObjekt;
    public GameObject gulKnappObjekt;
    public GameObject rødKnappObjekt;
    public GameObject lillaKnappObjekt;
    public GameObject sortKnappObjekt;
    public GameObject grønnKnappObjekt;

    public Button blåKnapp;
    public Button rødKnapp;
    public Button grønnKnapp;
    public Button gulKnapp;
    public Button lillaKnapp;
    public Button sortKnapp;

    void Start()
    {
        blå = false;
        gul = false;
        rød = false;
        sort = false;
        lilla = false;
        grønn = false;

        blåKnapp.onClick.AddListener(blåKlikket);
        rødKnapp.onClick.AddListener(rødKlikket);
        gulKnapp.onClick.AddListener(gulKlikket);
        grønnKnapp.onClick.AddListener(grønnKlikket);
        lillaKnapp.onClick.AddListener(lillaKlikket);
        sortKnapp.onClick.AddListener(sortKlikket);

        nyRett = false;
        nyFeil = false;

        seEtterRekvisisjon();

    }

    void Update()
    {
        poengTekst.text = PlayerPrefs.GetInt("Spillscore").ToString();
        StartCoroutine(poengFarge());
        StartCoroutine(ventPaaNesteScene(nesteScene));
    }


    void sortKlikket()
    {
        if (sort)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            sortKnappObjekt.SetActive(false);
            nyRett = true;
            rettTone.Play();
            sort = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void blåKlikket()
    {
        if (blå)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            blåKnappObjekt.SetActive(false);
            nyRett = true;
            rettTone.Play();
            blå = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void gulKlikket()
    {
        if (gul)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            gulKnappObjekt.SetActive(false);
            nyRett = true;
            rettTone.Play();
            gul = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void lillaKlikket()
    {
        if (lilla)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            lillaKnappObjekt.SetActive(false);
            nyRett = true;
            rettTone.Play();
            lilla = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void rødKlikket()
    {
        if (rød)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            rødKnappObjekt.SetActive(false);
            nyRett = true;
            rettTone.Play();
            rød = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void grønnKlikket()
    {
        if (grønn)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            grønnKnappObjekt.SetActive(false);
            nyRett = true;
            rettTone.Play();
            grønn = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
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

        if (!sort && !rød && !blå && !gul && !lilla && !grønn)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(scene);
        }


    }

    public void seEtterRekvisisjon()
    {

        int rekNr = PlayerPrefs.GetInt("Rekvisisjon");

        switch (rekNr)
        {
            case 1:
                //Kari
                rød = true;
                lilla = true;
                sort = true;
                break;

            case 2:
                //Ola
                blå = true;
                rød = true;
                lilla = true;
                break;

            case 3:
                //linda
                blå = true;
                gul = true;
                grønn = true;
                lilla = true;
                break;

            default:
                break;

        }
    }

}