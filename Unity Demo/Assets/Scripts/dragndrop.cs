using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dragndrop : MonoBehaviour
{


    public GameObject rødEtikett, blåEtikett, lillaEtikett, gulEtikett, sortEtikett, grønnEtikett;
    public Button rødtRør, blåttRør, lillaRør, gultRør, sortRør, grøntRør;
    Vector2 rødEtikettPos, blåEtikettPos, lillaEtikettPos, gulEtikettPos, sortEtikettPos, grønnEtikettPos;
    public Sprite rødtRørMedEtikett, blåttRørMedEtikett, lillaRørMedEtikett, gultRørMedEtikett, sortRørMedEtikett, grøntRørMedEtikett;
    public Text poengTekst;
    public int poeng;

    public bool minusPoeng, plussPoeng;

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
        minusPoeng = false;
        plussPoeng = false;

        StartCoroutine(poengFarge());
    }

  // Update is called once per frame
    void Update()
    {
        poengTekst.text = poeng.ToString();

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


    IEnumerator poengFarge()
    {
        if (plussPoeng)
        {
          poengTekst.color = Color.green;
          yield return new WaitForSeconds(2);
          poengTekst.color = Color.black;
        }

        if (minusPoeng)
        {


            poengTekst.color = Color.red;
            yield return new WaitForSeconds(2);
            poengTekst.color = Color.black;
        }

      
       
       

    }
     public void DropRød()
    {
        float Distance = Vector3.Distance(rødEtikett.transform.position, rødtRør.transform.position);
        if(Distance < 50)
        {
            rødEtikett.transform.position = rødtRør.transform.position;
            rødtRør.GetComponent<Image>().sprite = rødtRørMedEtikett;
            rødEtikett.SetActive(false);
            poeng++;
            plussPoeng = true;

        }
        else
        {
            rødEtikett.transform.position = rødEtikettPos;
            minusPoeng = true;
            poeng--;
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
            poeng++;

        }
        else
        {
            blåEtikett.transform.position = blåEtikettPos;
            poeng--;
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
            poeng++;

        }
        else
        {
            lillaEtikett.transform.position = lillaEtikettPos;
            poeng--;
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
            poeng++;

        }
        else
        {
            gulEtikett.transform.position = gulEtikettPos;
            poeng--;
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
            poeng++;

        }
        else
        {
            sortEtikett.transform.position = sortEtikettPos;
            poeng--;
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
            poeng++;

        }
        else
        {
            grønnEtikett.transform.position = grønnEtikettPos;
            poeng--;
        }
    }

 
    // private void OnMouseOver()
    //{
    //    rør1.Select();
    //}



}
