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

            var z = Input.gyro.attitude.eulerAngles;

        var rotation = Input.gyro.rotationRate;
        //SetAntallTekst("z = " + z);

        // SetAntallTekst("rotation = " + rotation);


        accelerationDir = Input.acceleration;
        var ny = Input.acceleration.z;
        SetAntallTekst("grader" + ny);
        if (ny < 180f)
        {
          antall = antall + 1;
        //  SetAntallTekst("grader: " + ny);
        }
       
        if(accelerationDir.sqrMagnitude >= 10f){
            SetAntallTekst("Du ristet for hardt og ødela prøven!");
        }
        
    }

    void SetAntallTekst(string i){
        antallTekst.text = i;
    }
}
