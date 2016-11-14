using UnityEngine;
using System.Collections;

public class HoleScript : MonoBehaviour {


    public GameObject ball;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            // WON
            Debug.Log("WON");
            ball.SetActive(false);
        }
    }
}
