using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HoleScript : MonoBehaviour {


    public GameObject ball;
    public GameObject resultScreen;
    public GameObject restartBtn;
    public GameObject nextLevelBtn;
    private bool isLost = false;
    public Text resultText;
    private bool isTriggered = false;
    Transform ballStart;
    
    void Start()
    {
        isLost = false;
        isTriggered = false;
        resultScreen.SetActive(false);
    }

    void Update()
    {
        if (ball.GetComponent<Rigidbody2D>().velocity.magnitude == 0 && PlayerController.canLose && !isLost && !isTriggered)
        {
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
        }
    }

    void showResult(int result)
    {
        resultScreen.SetActive(true);
        switch (result)
        {
            case 1:
                resultText.text = "Result : WINNER";
                restartBtn.SetActive(false);
                nextLevelBtn.SetActive(true);
                break;
            case 0:
                resultText.text = "Result : LOST";
                restartBtn.SetActive(true);
                nextLevelBtn.SetActive(false);
                break;               
        }

    }
}
