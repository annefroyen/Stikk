using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class snu : MonoBehaviour
{

    Vector3 accelerationDir;
    public Text tekst;
    public int antall;

    private void Start()
    {
        antall = 0;
        SetTekst("Tekst: ");
    }

    void Update()
    {

       // var eulerAngles = Input.gyro.attitude.eulerAngles;
       // var rotationRate = Input.gyro.rotationRate;
        var accelerationZ = Input.acceleration.z;

        SetTekst("Acceleration.z: " + accelerationZ);

        accelerationDir = Input.acceleration;  
        if(accelerationDir.sqrMagnitude >= 10f){
            SetTekst("Du ristet for hardt og ødela prøven!");
        }
        
    }

    void SetTekst(string i){
        tekst.text = i;
    }
}
