using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Choice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject rett;
    public GameObject rett1;
    public GameObject rett2;
    public GameObject rett3;
    public GameObject rett4;
    public GameObject rett5;

    public int ChoiceMade;

    public void ChoiceOption()
    {
        TextBox.GetComponent<Text>().text = "Hvordan går det med deg?";
        ChoiceMade = 1;
    }

    public void ChoiceOption1()
    {
        TextBox.GetComponent<Text>().text = "Går du på noe medisiner?";
        ChoiceMade = 2;
    }

    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Hva er personnummeret ditt?";
        ChoiceMade = 3;
    }

    public void ChoiceOption3()
    {
        TextBox.GetComponent<Text>().text = "Kan du si navnet ditt og personnummeret til meg?";
        ChoiceMade = 4;
    }

    public void ChoiceOption4()
    {
        TextBox.GetComponent<Text>().text = "Kan du si navnet ditt og personnummeret til meg?";
        ChoiceMade = 5;
    }

    public void ChoiceOption5()
    {
        TextBox.GetComponent<Text>().text = "Kan du si navnet ditt og personnummeret til meg?";
        ChoiceMade = 6;
    }




    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            rett.SetActive (false);
            rett1.SetActive(false);
            rett2.SetActive(false);
            rett3.SetActive(false);
            rett4.SetActive(false);
            rett5.SetActive(false);
        }
    }
}
