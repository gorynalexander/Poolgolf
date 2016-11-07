using UnityEngine;
using System.Collections;

public class HoleScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            // WON
            Debug.Log("WON");
        }
    }
}
