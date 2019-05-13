using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruksjoner : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject instruksjoner; 

    void Start()
    {
       int førsteKjøring =  PlayerPrefs.GetInt("FørsteKjøring");

        if(førsteKjøring == 0)
        {
            instruksjoner.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
