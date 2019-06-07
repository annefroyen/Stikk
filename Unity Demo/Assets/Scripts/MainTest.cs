using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class MainTest : MonoBehaviour
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
    public Button kanyleDelKnapp;

    public Text text;
    public Text staseKnappTekst;
    public Text poengTekst;

    public bool kanyle;
    public bool staseband;
    public bool teip;
    public bool bomull;
    public bool desinfeksjonsmiddel;
    public bool blå;
    public bool rød;
    public bool grønn;
    public bool gul;
    public bool lilla;
    public bool sort;
    private bool nyRett;
    private bool nyFeil;

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

    public AudioSource feilTone;
    public AudioSource rettTone;

    public RawImage rawImage;

    public GameObject blockerPanel;
    public Image poengPanel;

    public GameObject staseKnappObjekt;
    public GameObject desinfiserKnappObjekt;
    public GameObject kanyleKnappObjekt;
    public GameObject kanyleDelKnappObjekt;
    public GameObject blåKnappObjekt;
    public GameObject gulKnappObjekt;
    public GameObject rødKnappObjekt;
    public GameObject lillaKnappObjekt;
    public GameObject sortKnappObjekt;
    public GameObject grønnKnappObjekt;

    public Sprite rødBlodSprite;
    public Sprite blåBlodSprite;
    public Sprite gulBlodSprite;
    public Sprite lillaBlodSprite;
    public Sprite sortBlodSprite;
    public Sprite grønnBlodSprite;

    public Sprite rødSprite;
    public Sprite blåSprite;
    public Sprite gulSprite;
    public Sprite lillaSprite;
    public Sprite sortSprite;
    public Sprite grønnSprite;

    void Start()
    {

        SetTekst("Tekst");

        blåKnappObjekt.GetComponent<Image>().sprite = blåSprite;
        rødKnappObjekt.GetComponent<Image>().sprite = rødSprite;
        gulKnappObjekt.GetComponent<Image>().sprite = gulSprite;
        grønnKnappObjekt.GetComponent<Image>().sprite = grønnSprite;
        lillaKnappObjekt.GetComponent<Image>().sprite = lillaSprite;
        sortKnappObjekt.GetComponent<Image>().sprite = sortSprite;



        kanyle = false;
        staseband = false;
        teip = false;
        bomull = false;
        desinfeksjonsmiddel = false;
        blå = true;
        gul = true;
        rød = true;
        sort = true;
        lilla = true;
        grønn = true;

        nyRett = false;
        nyFeil = false;

        kanyleKnapp.onClick.AddListener(kanyleKlikket);
        kanyleDelKnapp.onClick.AddListener(kanyleKlikket);
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

        seEtterRekvisisjon();
        sjekkOmBrukt();
        //seEtterRør();


    }

    void Update()
    {
        poengTekst.text = PlayerPrefs.GetInt("Spillscore").ToString();



        StartCoroutine(poengFarge());

    }


    void stasebandKlikket()
    {
        if (!staseband)
        {
            staseband = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("StaseBrukt", 1);
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(stramStaseVideo));
            staseKnappObjekt.SetActive(false);
            videoPlayer.loopPointReached += LoadScene;
            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("finn vene");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void desinfeksjonsmiddelKlikket()
    {
        if (staseband && !desinfeksjonsmiddel)
        {
            desinfeksjonsmiddel = true;
            desinfiserKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("DesinfeksjonBrukt", 1);
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(desinfiserVideo));

        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }

    }

    void kanyleKlikket()
    {
        if (desinfeksjonsmiddel && !kanyle)
        {
            kanyle = true;
            kanyleKnappObjekt.SetActive(false);
            kanyleDelKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("KanyleBrukt", 1);
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(stikkVideo));



        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }



    void blåKlikket()
    {

        if (kanyle && !blå)
        {
            blå = true;
            blåKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("BlåBrukt", 1);
            PlayerPrefs.SetString("Farge", "blå");

            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(blåVideo));

            videoPlayer.loopPointReached += LoadScene;

            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("Vending");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void rødKlikket()
    {

        if (kanyle && blå && !rød)
        {
            rød = true;
            rødKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetString("Farge", "rød");
            PlayerPrefs.SetInt("RødBrukt", 1);
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(rødVideo));

            videoPlayer.loopPointReached += LoadScene;

            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("Vending");
            }


        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void gulKlikket()
    {

        if (kanyle && blå && rød && !gul)
        {
            gul = true;
            gulKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("GulBrukt", 1);
            PlayerPrefs.SetString("Farge", "gul");
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(gulVideo));

            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("Vending");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void grønnKlikket()
    {

        if (kanyle && blå && rød && gul && !grønn)
        {
            grønn = true;
            grønnKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("GrønnBrukt", 1);
            PlayerPrefs.SetString("Farge", "grønn");
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(grønnVideo));

            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("Vending");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void lillaKlikket()
    {

        if (kanyle && blå && rød && gul && grønn && !lilla)
        {
            lilla = true;
            lillaKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("LillaBrukt", 1);
            PlayerPrefs.SetString("Farge", "lilla");
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(lillaVideo));

            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("Vending");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void sortKlikket()
    {

        if (kanyle && blå && rød && gul && grønn && lilla && !sort)
        {
            sort = true;
            sortKnappObjekt.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            PlayerPrefs.SetInt("SortBrukt", 1);
            PlayerPrefs.SetString("Farge", "sort");
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(sortVideo));

            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("Vending");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    void bomullKlikket()
    {
        if (blå && rød && gul && grønn && lilla && sort && !bomull)
        {
            bomull = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            nyRett = true;
            rettTone.Play();
            StartCoroutine(playVideo(bomullVideo));
        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }

    }

    void teipKlikket()
    {
        if (bomull && !teip)
        {
            teip = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            nyRett = true;
            rettTone.Play();

            StartCoroutine(playVideo(teipVideo));

            videoPlayer.loopPointReached += LoadScene;

            void LoadScene(VideoPlayer vp)
            {
                SceneManager.LoadScene("merking");
            }

        }
        else
        {
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
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

        if (staseband)
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

    private IEnumerator poengFarge()
    {
        if (nyRett)
        {
            poengPanel.color = Color.green;
            yield return new WaitForSeconds(1);
            poengPanel.color = Color.white;
            nyRett = false;

        }

        if (nyFeil)
        {
            poengPanel.color = Color.red;
            yield return new WaitForSeconds(1);
            poengPanel.color = Color.white;
            nyFeil = false;
        }
    }

    public void seEtterRekvisisjon()
    {

        int rekNr = PlayerPrefs.GetInt("Rekvisisjon");

        switch (rekNr)
        {
            case 1:
                //Kari
                rød = false;
                rødKnappObjekt.SetActive(true);
                lilla = false;
                lillaKnappObjekt.SetActive(true);
                sort = false;
                sortKnappObjekt.SetActive(true);
                break;

            case 2:
                //Ola
                blå = false;
                blåKnappObjekt.SetActive(true);
                rød = false;
                rødKnappObjekt.SetActive(true);
                lilla = false;
                lillaKnappObjekt.SetActive(true);
                break;

            case 3:
                //linda
                blå = false;
                blåKnappObjekt.SetActive(true);
                gul = false;
                gulKnappObjekt.SetActive(true);
                grønn = false;
                grønnKnappObjekt.SetActive(true);
                lilla = false;
                lillaKnappObjekt.SetActive(true);
                break;

            default:
                break;

        }
    }

    public void sjekkOmBrukt()
    {
        int staseBrukt = PlayerPrefs.GetInt("StaseBrukt");
        if (staseBrukt == 1)
        {
            staseKnappObjekt.SetActive(false);
            staseband = true;
        }

        int desinfeksjonBrukt = PlayerPrefs.GetInt("DesinfeksjonBrukt");
        if (desinfeksjonBrukt == 1)
        {
            desinfiserKnappObjekt.SetActive(false);
            desinfeksjonsmiddel = true;
        }

        int kanyleBrukt = PlayerPrefs.GetInt("KanyleBrukt");
        if (kanyleBrukt == 1)
        {
            kanyleKnappObjekt.SetActive(false);
            kanyleDelKnappObjekt.SetActive(false);
            kanyle = true;
        }

        int blåBrukt = PlayerPrefs.GetInt("BlåBrukt");
        if (blåBrukt == 1)
        {
            blåKnappObjekt.GetComponent<Image>().sprite = blåBlodSprite;
            blå = true;
        }

        int rødBrukt = PlayerPrefs.GetInt("RødBrukt");
        if (rødBrukt == 1)
        {
            rødKnappObjekt.GetComponent<Image>().sprite = rødBlodSprite;
            rød = true;
        }

        int gulBrukt = PlayerPrefs.GetInt("GulBrukt");
        if (gulBrukt == 1)
        {
            gulKnappObjekt.GetComponent<Image>().sprite = gulBlodSprite;
            gul = true;
        }

        int grønnBrukt = PlayerPrefs.GetInt("GrønnBrukt");
        if (grønnBrukt == 1)
        {
            grønnKnappObjekt.GetComponent<Image>().sprite = grønnBlodSprite;
            grønn = true;
        }

        int lillaBrukt = PlayerPrefs.GetInt("LillaBrukt");
        if (lillaBrukt == 1)
        {
            lillaKnappObjekt.GetComponent<Image>().sprite = lillaBlodSprite;
            lilla = true;
        }

        int sortBrukt = PlayerPrefs.GetInt("SortBrukt");
        if (sortBrukt == 1)
        {
            sortKnappObjekt.GetComponent<Image>().sprite = sortBlodSprite;
            sort = true;
        }



    }

    public void seEtterRør()
    {
        int rødStatus = PlayerPrefs.GetInt("RødStatus");
        if (rødStatus == 1)
        {
            rødKnappObjekt.GetComponent<Image>().sprite = rødBlodSprite;
        }

        int blåStatus = PlayerPrefs.GetInt("BlåStatus");
        if (blåStatus == 1)
        {
            blåKnappObjekt.GetComponent<Image>().sprite = blåBlodSprite;
        }

        int gulStatus = PlayerPrefs.GetInt("GulStatus");
        if (gulStatus == 1)
        {
            gulKnappObjekt.GetComponent<Image>().sprite = gulBlodSprite;
        }

        int grønnStatus = PlayerPrefs.GetInt("GrønnStatus");
        if (grønnStatus == 1)
        {
            grønnKnappObjekt.GetComponent<Image>().sprite = grønnBlodSprite;
        }
        int lillaStatus = PlayerPrefs.GetInt("LillaStatus");
        if (rødStatus == 1)
        {
            lillaKnappObjekt.GetComponent<Image>().sprite = lillaBlodSprite;
        }
        int sortStatus = PlayerPrefs.GetInt("SortStatus");
        if (sortStatus == 1)
        {
            sortKnappObjekt.GetComponent<Image>().sprite = sortBlodSprite;
        }

    }
}

