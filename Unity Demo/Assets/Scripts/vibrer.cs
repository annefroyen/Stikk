using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vibrer : MonoBehaviour
{

    public Button veneKnapp;
    // Start is called before the first frame update
    void Start()
    {

        veneKnapp.onClick.AddListener(veneKlikket);

    }

    public void viber()
    {
        Handheld.Vibrate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void veneKlikket()
    {
        //lyd
        //vibrasjon
        //"du fann rett vene!"
        //load new scene

    }


   
}
