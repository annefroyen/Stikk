using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class snu : MonoBehaviour
{

    Vector3 accelerationDir;
    public Text antallTekst;
    public int antall;

    private void Start()
    {
        antall = 0;
        SetAntallTekst("antall snu: ");
        //tall = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        accelerationDir = Input.acceleration;
       if (Input.acceleration.x < -0.1f)
        {
            antall = antall + 1;
            SetAntallTekst("Antall: " + antall);
        }


        if(accelerationDir.sqrMagnitude >= 10f)
        {
            SetAntallTekst("Du ristet for hardt og ødela prøven!");
        }
       // transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
        
    }

    void SetAntallTekst(string i)
    {
        antallTekst.text = i;
    }
}
