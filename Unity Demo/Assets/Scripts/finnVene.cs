using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finnVene : MonoBehaviour
{




    public Text spillscore;
    public GameObject SlakkStaseKnapp;
    public Image poengPanel;
    public bool nyRett;

    // Start is called before the first frame update
    void Start()
    {
        nyRett = false;
        spillscore.text = PlayerPrefs.GetInt("Spillscore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(poengFarge());
        spillscore.text = PlayerPrefs.GetInt("Spillscore").ToString();

    }

    public void setVeneFunnet()
    {
        
        PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + 1);
        nyRett = true;
        SlakkStaseKnapp.SetActive(true);
    }

    public void veneKlikket()
    {
        
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

 
    }
}
