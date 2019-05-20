using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dragndrop : MonoBehaviour
{

    public GameObject rødEtikett, blåEtikett, lillaEtikett, gulEtikett, sortEtikett, grønnEtikett;
    public GameObject rødKnappObjekt, blåKnappObjekt, lillaKnappObjekt, gulKnappObjekt, sortKnappObjekt, grønnKnappObjekt;
    public Button rødtRør, blåttRør, lillaRør, gultRør, sortRør, grøntRør;
    Vector2 rødEtikettPos, blåEtikettPos, lillaEtikettPos, gulEtikettPos, sortEtikettPos, grønnEtikettPos;
    public Sprite rødtRørMedEtikett, blåttRørMedEtikett, lillaRørMedEtikett, gultRørMedEtikett, sortRørMedEtikett, grøntRørMedEtikett;
    public Text poengTekst;
    public int poeng;

    public string nesteScene;
    public Image poengPanel;

    public bool nyRett, nyFeil;
    public bool rød, blå, gul, lilla, sort, grønn;
    public Sprite etikettKariRød, etikettKariLilla, etikettKariSort, etikettOlaBlå, etikettOlaRød, etikettOlaLilla, etikettLindaGul, etikettLindaGrønn, etikettLindaLilla, etikettLindaBlå;

    public AudioSource feilTone, rettTone;

    // Start is called before the first frame update
    void Start()
    {
        

        rødEtikettPos = rødEtikett.transform.position;
        blåEtikettPos = blåEtikett.transform.position;
        lillaEtikettPos = lillaEtikett.transform.position;
        gulEtikettPos = gulEtikett.transform.position;
        sortEtikettPos = sortEtikett.transform.position;
        grønnEtikettPos = grønnEtikett.transform.position;
        poeng = 0;
        nyRett = false;
        nyFeil = false;
        rød = false;
        blå = false;
        grønn = false;
        lilla = false;
        gul = false;
        sort = false;

        StartCoroutine(poengFarge());

        seEtterRekvisisjon();
    }

  // Update is called once per frame
    void Update()
    {
        poengTekst.text = PlayerPrefs.GetInt("Spillscore").ToString();
        StartCoroutine(poengFarge());
        StartCoroutine(ventPaaNesteScene(nesteScene));


    }

    public void DragRød()
    {
        rødEtikett.transform.position = Input.mousePosition;
    }

    public void DragBlå()
    {
        blåEtikett.transform.position = Input.mousePosition;
    }

    public void DragLilla()
    {
        lillaEtikett.transform.position = Input.mousePosition;
    }

    public void DragGul()
    {
        gulEtikett.transform.position = Input.mousePosition;
    }

    public void DragSort()
    {
        sortEtikett.transform.position = Input.mousePosition;
    }

    public void DragGrønn()
    {
        grønnEtikett.transform.position = Input.mousePosition;
    }



     public void DropRød()
    {
        float Distance = Vector3.Distance(rødEtikett.transform.position, rødtRør.transform.position);
        if(Distance < 50)
        {
            rødEtikett.transform.position = rødtRør.transform.position;
            rødtRør.GetComponent<Image>().sprite = rødtRørMedEtikett;
            rødEtikett.SetActive(false);
           // poeng++;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            nyRett = true;
            rettTone.Play();
            rød = false;

        }
        else
        {
            rødEtikett.transform.position = rødEtikettPos;
            nyFeil = true;
            feilTone.Play();
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            //poeng--;
        }
    }

    public void DropBlå()
    {
        float Distance = Vector3.Distance(blåEtikett.transform.position, blåttRør.transform.position);
        if (Distance < 50)
        {
            blåEtikett.transform.position = blåttRør.transform.position;
            blåttRør.GetComponent<Image>().sprite = blåttRørMedEtikett;
            blåEtikett.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            blå = false;
            nyRett = true;
            rettTone.Play();
            
           // poeng++;

        }
        else
        {
            blåEtikett.transform.position = blåEtikettPos;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
            
            //poeng--;
        }
    }

    public void DropLilla()
    {
        float Distance = Vector3.Distance(lillaEtikett.transform.position, lillaRør.transform.position);
        if (Distance < 50)
        {
            lillaEtikett.transform.position = lillaRør.transform.position;
            lillaRør.GetComponent<Image>().sprite = lillaRørMedEtikett;
            lillaEtikett.SetActive(false);
           // poeng++;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            lilla = false;
            nyRett = true;
            rettTone.Play();

        }
        else
        {
            lillaEtikett.transform.position = lillaEtikettPos;
            //poeng--;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    public void DropGul()
    {
        float Distance = Vector3.Distance(gulEtikett.transform.position, gultRør.transform.position);
        if (Distance < 50)
        {
            gulEtikett.transform.position = gultRør.transform.position;
            gultRør.GetComponent<Image>().sprite = gultRørMedEtikett;
            gulEtikett.SetActive(false);
            //  poeng++;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            gul = false;
            nyRett = true;
            rettTone.Play();

        }
        else
        {
            gulEtikett.transform.position = gulEtikettPos;
            //poeng--;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    public void DropSort()
    {
        float Distance = Vector3.Distance(sortEtikett.transform.position, sortRør.transform.position);
        if (Distance < 50)
        {
            sortEtikett.transform.position = sortRør.transform.position;
            sortRør.GetComponent<Image>().sprite = sortRørMedEtikett;
            sortEtikett.SetActive(false);
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            sort = false;
            nyRett = true;
            rettTone.Play();
            //poeng++;

        }
        else
        {
            sortEtikett.transform.position = sortEtikettPos;
           // poeng--;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
        }
    }

    public void DropGrønn()
    {
        float Distance = Vector3.Distance(grønnEtikett.transform.position, grøntRør.transform.position);
        if (Distance < 50)
        {
            grønnEtikett.transform.position = grøntRør.transform.position;
            grøntRør.GetComponent<Image>().sprite = grøntRørMedEtikett;
            grønnEtikett.SetActive(false);
            nyRett = true;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
            grønn = false;
            rettTone.Play();


        }
        else
        {
            grønnEtikett.transform.position = grønnEtikettPos;
            PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") - 1);
            nyFeil = true;
            feilTone.Play();
           // poeng--;
        }
    }




    public void seEtterRekvisisjon()
    {

        int rekNr = PlayerPrefs.GetInt("Rekvisisjon");

        switch (rekNr)
        {
            case 1:
                //Kari
                rødKnappObjekt.SetActive(true);
                rødEtikett.GetComponent<Image>().sprite = etikettKariRød;
                rødEtikett.SetActive(true);
                rød = true;

                lillaKnappObjekt.SetActive(true);
                lillaEtikett.GetComponent<Image>().sprite = etikettKariLilla;
                lillaEtikett.SetActive(true);
                lilla = true;

                sortKnappObjekt.SetActive(true);
                sortEtikett.GetComponent<Image>().sprite = etikettKariSort;
                sortEtikett.SetActive(true);
                sort = true;
                break;

            case 2:
                //Ola
                blåKnappObjekt.SetActive(true);
                blåEtikett.GetComponent<Image>().sprite = etikettOlaBlå;
                blåEtikett.SetActive(true);
                blå = true;

                rødKnappObjekt.SetActive(true);
                rødEtikett.GetComponent<Image>().sprite = etikettOlaRød;
                rødEtikett.SetActive(true);
                rød = true;

                lillaKnappObjekt.SetActive(true);
                lillaEtikett.SetActive(true);
                lillaEtikett.GetComponent<Image>().sprite = etikettOlaLilla;
                lilla = true;
                break;

            case 3:
                //linda
                blåKnappObjekt.SetActive(true);
                blåEtikett.GetComponent<Image>().sprite = etikettLindaBlå;
                blåEtikett.SetActive(true);
                blå = true;

                gulKnappObjekt.SetActive(true);
                gulEtikett.GetComponent<Image>().sprite = etikettLindaGul;
                gulEtikett.SetActive(true);
                gul = true;

                grønnKnappObjekt.SetActive(true);
                grønnEtikett.GetComponent<Image>().sprite = etikettLindaGrønn;
                grønnEtikett.SetActive(true);
                grønn = true;

                lillaKnappObjekt.SetActive(true);
                lillaEtikett.GetComponent<Image>().sprite = etikettLindaLilla;
                lillaEtikett.SetActive(true);
                lilla = true;
                break;

            default:
                break;
        }
    }


    public IEnumerator ventPaaNesteScene(string scene)
    {

        if (!sort && !blå && !gul && !rød && !lilla && !grønn)
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(scene);
        }


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
}
