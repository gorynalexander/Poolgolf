using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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

    

}
