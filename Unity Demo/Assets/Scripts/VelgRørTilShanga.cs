using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VelgRørTilShanga : MonoBehaviour
{

   

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

        seEtterRekvisisjon();

    }

    void Update()
    {
       
 
        StartCoroutine(ventPaaNesteScene(nesteScene));
    }


    void sortKlikket()
    {
        if (sort)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            sortKnappObjekt.SetActive(false);
           
            sort = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
           
        }
    }

    void blåKlikket()
    {
        if (blå)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            blåKnappObjekt.SetActive(false);
           
            blå = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
          
        }
    }

    void gulKlikket()
    {
        if (gul)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            gulKnappObjekt.SetActive(false);
           
            gul = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
           
        }
    }

    void lillaKlikket()
    {
        if (lilla)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            lillaKnappObjekt.SetActive(false);
          
            lilla = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
           
        }
    }

    void rødKlikket()
    {
        if (rød)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            rødKnappObjekt.SetActive(false);
            
            rød = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            
        }
    }

    void grønnKlikket()
    {
        if (grønn)
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            grønnKnappObjekt.SetActive(false);
           
            grønn = false;
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
           
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