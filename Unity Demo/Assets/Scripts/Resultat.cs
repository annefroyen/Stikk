using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resultat : MonoBehaviour
{

    public Text ssTekst;
    public Text nyHighscore;
    int highscore;
    int spillscore;
    

    void Start()
    {
       
        spillscore = PlayerPrefs.GetInt("Spillscore");
        highscore = PlayerPrefs.GetInt("Highscore");
        

        if (spillscore > highscore)
        {
            PlayerPrefs.SetInt("Highscore", spillscore);
            nyHighscore.text = "Ny highscore!";  
        }
     

        ssTekst.text = spillscore.ToString();
      
            

    }

    // Update is called once per frame
    void Update()
    {
    }


    
     
}
