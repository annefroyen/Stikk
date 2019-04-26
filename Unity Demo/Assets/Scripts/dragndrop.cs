using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dragndrop : MonoBehaviour
{


    public GameObject rødEtikett, blåEtikett, lillaEtikett, gulEtikett, sortEtikett, grønnEtikett;
    public Button rødtRør, blåttRør, lillaRør, gultRør, sortRør, grøntRør;
    Vector2 rødEtikettPos, blåEtikettPos, lillaEtikettPos, gulEtikettPos, sortEtikettPos, grønnEtikettPos;

    // Start is called before the first frame update
    void Start()
    {
        rødEtikettPos = rødEtikett.transform.position;
        blåEtikettPos = blåEtikett.transform.position;
        lillaEtikettPos = lillaEtikett.transform.position;
        gulEtikettPos = gulEtikett.transform.position;
        sortEtikettPos = sortEtikett.transform.position;
        grønnEtikettPos = grønnEtikett.transform.position;
    }

  // Update is called once per frame
    void Update()
    {

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
           
        }
        else
        {
            rødEtikett.transform.position = rødEtikettPos;
        }
    }

    public void DropBlå()
    {
        float Distance = Vector3.Distance(blåEtikett.transform.position, blåttRør.transform.position);
        if (Distance < 50)
        {
            blåEtikett.transform.position = blåttRør.transform.position;

        }
        else
        {
            blåEtikett.transform.position = blåEtikettPos;
        }
    }

    public void DropLilla()
    {
        float Distance = Vector3.Distance(lillaEtikett.transform.position, lillaRør.transform.position);
        if (Distance < 50)
        {
            lillaEtikett.transform.position = lillaRør.transform.position;

        }
        else
        {
            lillaEtikett.transform.position = lillaEtikettPos;
        }
    }

    public void DropGul()
    {
        float Distance = Vector3.Distance(gulEtikett.transform.position, gultRør.transform.position);
        if (Distance < 50)
        {
            gulEtikett.transform.position = gultRør.transform.position;

        }
        else
        {
            gulEtikett.transform.position = gulEtikettPos;
        }
    }

    public void DropSort()
    {
        float Distance = Vector3.Distance(sortEtikett.transform.position, sortRør.transform.position);
        if (Distance < 50)
        {
            sortEtikett.transform.position = sortRør.transform.position;

        }
        else
        {
            sortEtikett.transform.position = sortEtikettPos;
        }
    }

    public void DropGrønn()
    {
        float Distance = Vector3.Distance(grønnEtikett.transform.position, grøntRør.transform.position);
        if (Distance < 50)
        {
            grønnEtikett.transform.position = grøntRør.transform.position;

        }
        else
        {
            grønnEtikett.transform.position = grønnEtikettPos;
        }
    }

 
    // private void OnMouseOver()
    //{
    //    rør1.Select();
    //}



}
