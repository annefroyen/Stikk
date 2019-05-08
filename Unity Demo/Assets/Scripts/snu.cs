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

    private void Start()
    {
        snudd = false;
        antallSnu = 10;
        SetTekst(farge);
        //farge = PlayerPrefs.GetString("Farge");


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
                
                SceneManager.LoadScene("MainTest");
                
            }

        }

        accelerationDir = Input.acceleration;  
        if(accelerationDir.sqrMagnitude >= 20f){
            antall.text = ("Du ristet for hardt og ødela prøven!");
        }
        
    }

    void SetTekst(string i){
        tekst.text = i;
    }
}
