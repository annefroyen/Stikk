using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class main : MonoBehaviour
{
    public Button kanyleKnapp;
    public Button staseKnapp;

    public Text text;
    
    public bool stase;
    public bool kanyle;
    public bool proveror1;
    public bool proveror2;
    public bool proveror3;


    private VideoPlayer videoPlayer;
    public MovieTexture MovieTexture;

    void Start()
    {
        SetTekst("Tekst");
        kanyle = false;
        stase = false;
        videoPlayer = GetComponent<VideoPlayer>();
       kanyleKnapp.onClick.AddListener(TaskOnClick);
       staseKnapp.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {
        GetComponent<Renderer>().material.mainTexture = MovieTexture;
        if (Input.GetButtonDown("kanyle"))
        {
            SetTekst("KANYLE TRYKKET");
            //kanyle er tyykt
            kanyle = true;
        }
       
    }


void TaskOnClick()
{
        //spill video
        if (kanyle)
        {
            SetTekst("Kanyle trykket");
            MovieTexture.Play();
            videoPlayer.Play();
            //spill video
            if (stase)
            {
                SetTekst("Stase trykket etter knayle");
                //spill video
            }
        }
   
}

    void SetTekst(string i)
    {
        text.text = i;
    }




}
