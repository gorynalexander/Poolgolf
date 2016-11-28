using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoleScript : MonoBehaviour {


    public GameObject ball;
    public GameObject resultScreen;
    public GameObject restartBtn;
    public GameObject nextLevelBtn;
    private bool isLost = false;
    public Text resultText;
    public Text attemptText;
    private bool isTriggered = false;
    public int countPassedLevels;
    
    void Start()
    {
        isLost = false;
        isTriggered = false;
        resultScreen.SetActive(false);
        countPassedLevels = PlayerPrefs.GetInt("count");
    }

    void Update()
    {
        if (ball.GetComponent<Rigidbody2D>().velocity.magnitude == 0 && PlayerController.canLose && !isLost && !isTriggered)
        {
            // LOST
            isLost = true;
            Debug.Log("LOST");
            showResult(0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            // WON
            isTriggered = true;
            Debug.Log("WON");
            ball.SetActive(false);
            showResult(1);
            PlayerPrefs.SetInt("count", PlayerPrefs.GetInt("count") + 1);
        }
    }

    void showResult(int result)
    {
        resultScreen.SetActive(true);
        attemptText.text = "Attempts : " + PlayerController.attempsCount;
        switch (result)
        {
            case 1:
                if (SceneManager.GetActiveScene().name == "Level4")
                {
                    resultText.text = "CONGRATULATION, YOU HAVE FINISHED THE GAME";
                    restartBtn.SetActive(false);
                    nextLevelBtn.SetActive(false);
                } else
                {
                    resultText.text = "Result : WINNER";
                    restartBtn.SetActive(false);
                    nextLevelBtn.SetActive(true);
                }
                
                break;
            case 0:
                resultText.text = "Result : LOST";
                restartBtn.SetActive(true);
                nextLevelBtn.SetActive(false);
                break;               
        }

    }
}
