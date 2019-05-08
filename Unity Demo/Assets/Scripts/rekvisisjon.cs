using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rekvisisjon : MonoBehaviour
{
    public GameObject content;

    public Sprite rekBilde1;
    public Sprite rekBilde2;
    public Sprite rekBilde3;
    public Sprite rekBilde4;
    public Sprite rekBilde5;
    public Sprite rekBilde6;


    // Start is called before the first frame update
    void Start()
    {

        int r = UnityEngine.Random.Range(1, 3);
        PlayerPrefs.SetInt("Rekvisisjon", r);

        switch (r)
        {
            case 1:
                content.GetComponent<Image>().sprite = rekBilde1;
                break;
            case 2:
                content.GetComponent<Image>().sprite = rekBilde2;
                break;
            case 3:
                content.GetComponent<Image>().sprite = rekBilde3;
                break;
            case 4:
                content.GetComponent<Image>().sprite = rekBilde4;
                break;
            case 5:
                content.GetComponent<Image>().sprite = rekBilde5;
                break;
            case 6:
                content.GetComponent<Image>().sprite = rekBilde6;
                break;
            default:
                content.GetComponent<Image>().sprite = rekBilde1;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
