using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snu : MonoBehaviour
{

    Vector3 accelerationDir;


    public GameObject rødtRør, blåttRør, gultRør, sortRør, lillaRør, grøntRør;
    public Text tekst;
    public Text antall;
    public int antallSnu;
    bool snudd;
    private string farge;

    public Text spillscore;
    public Image poengPanel;
    private bool nyRett;
    private bool nyFeil;
    public AudioSource rettTone;
    public AudioSource feilTone;

   
    private void Start()
    {
        snudd = false;
        nyRett = false;
        nyFeil = false;
        antallSnu = 6;
        SetTekst(farge);
        farge = PlayerPrefs.GetString("Farge");


        switch (farge)
        {
            case "blå":
                blåttRør.SetActive(true);
                PlayerPrefs.SetInt("BlåStatus", 1);
                break;

            case "rød":
                rødtRør.SetActive(true);
                PlayerPrefs.SetInt("RødStatus", 1);
                break;

            case "lilla":
                lillaRør.SetActive(true);
                PlayerPrefs.SetInt("LillaStatus", 1);
                break;

            case "grønn":
                grøntRør.SetActive(true);
                PlayerPrefs.SetInt("GrønnStatus", 1);
                break;

            case "gul":
                gultRør.SetActive(true);
                PlayerPrefs.SetInt("GulStatus", 1);
                break;

            case "sort":
                sortRør.SetActive(true);
                PlayerPrefs.SetInt("SortStatus", 1);
                break;

            default:
                break;

        }

    }

    void Update()
    {

        StartCoroutine(poengFarge());
        spillscore.text = PlayerPrefs.GetInt("Spillscore").ToString();

        var accelerationx = Input.acceleration.x;

        if(accelerationx > 0.9 && antallSnu > 0)
        {
            
            snudd = false;
        }

        if (snudd == false)
        {
            if (accelerationx < -0.9 && antallSnu > 0)
            {
               
                snudd = true;
                antallSnu--;
                antall.text = antallSnu.ToString();
            }

            if (antallSnu == 0)
            {
                PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
                nyRett = true;
                rettTone.Play();
                SceneManager.LoadScene("MainTest");
                
            }

        }

        accelerationDir = Input.acceleration;  
        if(accelerationDir.sqrMagnitude >= 20f){
            tekst.text = ("Du ristet for hardt og ødela prøven!");
            antallSnu = 7;
            nyFeil = true;
            feilTone.Play();

        }
        
    }

    void SetTekst(string i){
        tekst.text = i;
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

        if (nyFeil){
            poengPanel.color = Color.red;
            yield return new WaitForSeconds(1);
            poengPanel.color = Color.white;
            nyFeil = false;


        }


    }

}
