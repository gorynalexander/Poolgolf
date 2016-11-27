using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {



    public void LoadLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void loadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    

}
