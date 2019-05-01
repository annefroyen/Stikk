using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vibrer : MonoBehaviour
{

    public Button veneKnapp;
    public AudioSource puls;
    // Start is called before the first frame update
    void Start()
    {
        puls = GetComponent<AudioSource>();
        
        veneKnapp.onClick.AddListener(veneKlikket);
        Handheld.Vibrate();

    }

   
    // Update is called once per frame
    void Update()
    {
        
    }

    void veneKlikket()
    {

        //lyd
        puls.Play(0);
        //vibrasjon
        Handheld.Vibrate();
        //"du fann rett vene!"
        //load new scene

    }


   
}
