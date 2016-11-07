using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void LoadLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    void Exit()
    {
        Application.Quit();
    }
}
