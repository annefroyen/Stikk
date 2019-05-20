using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class UtstyrValgResultat : MonoBehaviour
{

    private int poeng;
    private int poengTotalt;
    public Text poengText;
    public Text poengTotaltText;

    // Start is called before the first frame update
    void Start()
    {
        poeng = PlayerPrefs.GetInt("valgAvUtstyrPoeng");
        poengText.text = poeng.ToString();

        PlayerPrefs.SetInt("Spillscore", PlayerPrefs.GetInt("Spillscore") + poeng);
        poengTotalt = PlayerPrefs.GetInt("Spillscore");
        poengTotaltText.text = poengTotalt.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
