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
    public Button teipKnapp;
    public Button bomullKnapp;
    public Button desinfeksjonsmiddelKnapp;
    public Button prøverørKnapp;

    public Text text;

    public bool kanyle;
    public bool staseband;
    public bool teip;
    public bool bomull;
    public bool desinfeksjonsmiddel;
    public bool prøverør;

    public VideoPlayer videoPlayer;
    public VideoSource videòSource;
    public VideoClip stramStaseVideo;
    public VideoClip slakkstaseVideo;
    public VideoClip desinfiserVideo;
    public VideoClip stikkVideo;
    public VideoClip blåttPrøverørVideo;
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

        kanyleKnapp.onClick.AddListener(kanyleKlikket);
        stasebandKnapp.onClick.AddListener(stasebandKlikket);
        desinfeksjonsmiddelKnapp.onClick.AddListener(desinfeksjonsmiddelKlikket);
        prøverørKnapp.onClick.AddListener(prøverørKlikket);
        bomullKnapp.onClick.AddListener(bomullKlikket);
        teipKnapp.onClick.AddListener(teipKlikket);

        blockerPanel.SetActive(false);
    }

    void Update()
    {
        
      
    }


    void stasebandKlikket()
    {
        if (!staseband) {
            staseband = true;
            SetTekst("VIDEO STASE");

            StartCoroutine(playVideo(stramStaseVideo));

           // videoPlayer.loopPointReached += LoadScene;
        
        void LoadScene(VideoPlayer vp)
        {
            SceneManager.LoadScene("finn vene");
        }

    } else {
            SetTekst("Error!");
        }

    }

    void desinfeksjonsmiddelKlikket() {
        if (staseband && !desinfeksjonsmiddel)
        {
            desinfeksjonsmiddel = true;
            SetTekst("VIDEO DESINFEKSJON");
            StartCoroutine(playVideo(desinfiserVideo));
        
        }
        else
        {
            SetTekst("error!");
        }

    }

    void kanyleKlikket()
    {
        if (staseband && desinfeksjonsmiddel && !kanyle)
        {
            kanyle = true;
            SetTekst("VIDEO KANYLE");
            StartCoroutine(playVideo(stikkVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void prøverørKlikket() {

        if(staseband && desinfeksjonsmiddel && kanyle && !prøverør)
        {
            prøverør = true;
            SetTekst("VIDEO PRØVERØR");
            StartCoroutine(playVideo(blåttPrøverørVideo));
        }
        else
        {
            SetTekst("error!");
        }
    }

    void bomullKlikket() {
        if (staseband && desinfeksjonsmiddel && kanyle && prøverør && !bomull)
        {
            bomull = true;
            SetTekst("VIDEO BOMULL");
            StartCoroutine(playVideo(bomullVideo));
        }
        else
        {
            SetTekst("error!");
        }

    }

    void teipKlikket() {
        if (staseband && desinfeksjonsmiddel && kanyle && prøverør && bomull && !teip)
        {
            teip = true;
            SetTekst("VIDEO TEIP");
            StartCoroutine(playVideo(teipVideo));
        }
        else
        {
            SetTekst("error!");
        }

    }
   
    void SetTekst(string i)
    {
        text.text = i;
    }

    IEnumerator playVideo(VideoClip videoClip)
    {




        blockerPanel.SetActive(true);

      //  videoPlayer = gameObject.AddComponent<VideoPlayer>();
      //  audioSource = gameObject.AddComponent<AudioSource>();

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



        videoPlayer.loopPointReached += setInactive;

        void setInactive(VideoPlayer vp)
        {
            blockerPanel.SetActive(false);
        }

    }
}

