using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nesteKnapp : MonoBehaviour
{
  
    public void neste(string SceneNavn)
    {
        SceneManager.LoadScene(SceneNavn);

    }
        
 
}
