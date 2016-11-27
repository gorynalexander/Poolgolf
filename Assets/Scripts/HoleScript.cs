using UnityEngine;
using System.Collections;

public class HoleScript : MonoBehaviour {


    public GameObject ball;
    private bool isLost = false;

    void Update()
    {
        if (ball.GetComponent<Rigidbody2D>().velocity.magnitude == 0 && PlayerController.isStarted && !isLost)
        {
            isLost = true;
            Debug.Log("LOST");
            showResult(1);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            // WON
            Debug.Log("WON");
            ball.SetActive(false);
            showResult(0);
        }
    }

    void showResult(int i)
    {
        

    }
}
