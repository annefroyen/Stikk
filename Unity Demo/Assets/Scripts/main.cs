using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class main : MonoBehaviour
{
    public Button kanyleKnapp;
    public Button stasebandKnapp;
    public Button staseKnapp;
    public Button teipKnapp;
    public Button bomullKnapp;
    public Button desinfeksjonsmiddelKnapp;
    public Button blåKnapp;
    public Button rødKnapp;
    public Button grønnKnapp;
    public Button gulKnapp;
    public Button lillaKnapp;
    public Button sortKnapp;

    public Text text;
    public Text staseKnappTekst;
    public Text poengTekst;

    public bool kanyle;
    public bool staseband;
    public bool teip;
    public bool bomull;
    public bool desinfeksjonsmiddel;
    public bool prøverør;
    public bool blå;
    public bool rød;
    public bool grønn;
    public bool gul;
    public bool lilla;
    public bool sort;


    public VideoPlayer videoPlayer;
    public VideoSource videòSource;
    public VideoClip stramStaseVideo;
    public VideoClip slakkStaseVideo;
    public VideoClip desinfiserVideo;
    public VideoClip stikkVideo;
    public VideoClip blåVideo;
    public VideoClip gulVideo;
    public VideoClip rødVideo;
    public VideoClip lillaVideo;
    public VideoClip sortVideo;
    public VideoClip grønnVideo;
    public VideoClip rødtPrøverørVideo;
    public VideoClip bomullVideo;
    public VideoClip teipVideo;
    public VideoClip monterKanyleVideo;

    public AudioSource audioSource;

    public RawImage rawImage;

    public GameObject blockerPanel;


    void Start()
    {
       
        SetTekst("Tekst");

        kanyle = false;
        staseband = false;
        teip = false;
        bomull = false;
        desinfeksjonsmiddel = false;
        prøverør = false;
        blå = false;
        gul = false;
        rød = false;
        sort = false;
        lilla = false;
        grønn = false;

        kanyleKnapp.onClick.AddListener(kanyleKlikket);
        stasebandKnapp.onClick.AddListener(stasebandKlikket);
        staseKnapp.onClick.AddListener(staseKnappKlikket);
        desinfeksjonsmiddelKnapp.onClick.AddListener(desinfeksjonsmiddelKlikket);
        blåKnapp.onClick.AddListener(blåKlikket);
        rødKnapp.onClick.AddListener(rødKlikket);
        gulKnapp.onClick.AddListener(gulKlikket);
        grønnKnapp.onClick.AddListener(grønnKlikket);
        lillaKnapp.onClick.AddListener(lillaKlikket);
        sortKnapp.onClick.AddListener(sortKlikket);

        bomullKnapp.onClick.AddListener(bomullKlikket);
        teipKnapp.onClick.AddListener(teipKlikket);

        

        blockerPanel.SetActive(false);
    }

    void Update()
    {
        poengTekst.text = PlayerPrefs.GetInt("Spillscore").ToString();


    }


    void stasebandKlikket()
    {
        if (!staseband) {
            staseband = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);

            StartCoroutine(playVideo(stramStaseVideo));

           

            // videoPlayer.loopPointReached += LoadScene;

            void LoadScene(VideoPlayer vp)
        {
            SceneManager.LoadScene("finn vene");
        }

    } else {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);


        }

    }

    void desinfeksjonsmiddelKlikket() {
        if (staseband && !desinfeksjonsmiddel)
        {
            desinfeksjonsmiddel = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(desinfiserVideo));
        
        }
        else
        {
            SetTekst("error!");
        }

    }

    void kanyleKlikket()
    {
        if (desinfeksjonsmiddel && !kanyle)
        {
            kanyle = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(stikkVideo));



        }
        else
        {
            SetTekst("error!");
        }
    }

   

    void blåKlikket()
    {

        if (kanyle && !blå)
        {
            blå = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(blåVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void rødKlikket()
    {

        if (blå && !rød)
        {
            rød = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(rødVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void gulKlikket()
    {

        if (rød && !gul)
        {
            gul = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(gulVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void grønnKlikket()
    {

        if (gul && !grønn)
        {
            grønn = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(grønnVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void lillaKlikket()
    {

        if (grønn && !lilla)
        {
            lilla = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(lillaVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void sortKlikket()
    {

        if (lilla && !sort)
        {
            sort = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(sortVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void bomullKlikket() {
        if (prøverør && !bomull)
        {
            bomull = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(bomullVideo));
        }
        else
        {
            SetTekst("error!");
        }

    }

    void teipKlikket() {
        if (bomull && !teip)
        {
            teip = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(teipVideo));
        }
        else
        {
            SetTekst("error!");
        }

    }


    void staseKnappKlikket()
    {
        if (!staseband)
        {
            staseband = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(stramStaseVideo));
            staseKnappTekst.text = "Slakk stase";
        
        }

        if(staseband)
        {
            staseband = false;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            StartCoroutine(playVideo(slakkStaseVideo));
            staseKnappTekst.text = "Stram stase";
            
            


        }

    }


    void SetTekst(string i)
    {
        text.text = i;
    }

    IEnumerator playVideo(VideoClip videoClip)
    {

      // blockerPanel.SetActive(true);

        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

        videoPlayer.clip = videoClip;

        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
       

    }
}

