using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ValgUtstyr : MonoBehaviour
{

    public Toggle ibuxKnapp;
    public Toggle paracetKnapp;
    public Toggle syringeKnapp;
    public Toggle proverorKnapp;
    public Toggle teipKnapp;
    public Toggle steteoskopKnapp;
    public Toggle termometerKnapp;
    public Toggle cupKnapp;
    public Toggle vanligBossKnapp;
    public Toggle staseKnapp;
    public Toggle bossKnapp;
    public Toggle antibacKnapp;
    public Toggle beholderKnapp;
    public Toggle kanyleKnapp;
    public Toggle bomullKnapp;

    public Button nesteKnapp;

    public Text text;
    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        ibuxKnapp.IsActive();
        paracetKnapp.IsActive();
        syringeKnapp.IsActive();
        proverorKnapp.IsActive();
        teipKnapp.IsActive();
        steteoskopKnapp.IsActive();
        termometerKnapp.IsActive();
        cupKnapp.IsActive();
        vanligBossKnapp.IsActive();
        staseKnapp.IsActive();
        bossKnapp.IsActive();
        antibacKnapp.IsActive();
        beholderKnapp.IsActive();
        kanyleKnapp.IsActive();
        bomullKnapp.IsActive();

        neste("");

       // neste.interactable = false;

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void bossClicked()
    {
        if (bossKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

    public void antibacClicked()
    {
        if (antibacKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

    public void beholderClicked()
    {
        if (beholderKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

    public void kanyleClicked()
    {
        if (kanyleKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

    public void bomullClicked()
    {
        if (bomullKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

    public void syringeClicked()
    {
        if (syringeKnapp.isOn)
        {
            score--;
        }
        else
        {
            score++;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

    public void proverorClicked()
    {
        if (proverorKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

    public void teipClicked()
    {
        if (teipKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }


    public void vanligClicked()
    {
        if (vanligBossKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }

        public void staseClicked()
    {
        if (staseKnapp.isOn)
        {
            score++;
        }
        else
        {
            score--;
        }
        scoreText.text = "Current Points" + score.ToString();
    }



    public void ibuxClicked()

    {
        if (ibuxKnapp.isOn)
        {
            score--;
        }
        else
        {
            score++;
        }
        scoreText.text = "Current Points" + score.ToString();

    }

    public void paracetClicked()
    {
            if (paracetKnapp.isOn)
            {
                score--;
            }
            else
            {
                score++;
            }
            scoreText.text = "Current Points" + score.ToString();
        }


    public void steteoskopClicked()
        {
                if (steteoskopKnapp.isOn)
                {
                    score--;
                }
                else
                {
                    score++;
                }
                scoreText.text = "Current Points" + score.ToString();
            }

    public void cupClicked()
    {
            if (cupKnapp.isOn)
            {
                score--;
            }
            else
            {
                score++;
            }
            scoreText.text = "Current Points" + score.ToString();
        }

    public void termometerClicked()
    {
        if (termometerKnapp.isOn)
        {
            score--;
        }
        else
        {
            score++;
        }
        scoreText.text = "Current Points" + score.ToString();
    }


    //kan gå vidare bare dersom man får minst 4 rette feks.
    public void neste(string SceneNavn)
    {
        PlayerPrefs.SetInt("valgAvUtstyrPoeng", score);
        SceneManager.LoadScene(SceneNavn);

    }


}


