using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public string mainMenu;


 

    public void CompleteLevel()
    {
       
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {

        SceneManager.LoadScene(mainMenu);

    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
    }

    public void MainMenu() {

        SceneManager.LoadScene(mainMenu);
    }


}
