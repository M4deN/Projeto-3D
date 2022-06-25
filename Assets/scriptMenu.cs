using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void sair()
    {
        Application.Quit();
    }
   
}
