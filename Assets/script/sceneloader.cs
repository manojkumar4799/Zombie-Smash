using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    public void loadnextscene()
    {
        int currentscene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentscene + 1);
    }
     public void startscene()
    {
       
        SceneManager.LoadScene(0);
        FindObjectOfType<gamestatus>().gameset();

    }
    public void quitgame()
    {
        Application.Quit();
    }
}
