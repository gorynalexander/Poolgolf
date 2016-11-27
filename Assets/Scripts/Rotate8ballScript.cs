using UnityEngine;
using System.Collections;

public class Rotate8ballScript : MonoBehaviour {
    public Transform[] ballT;

	void Update () {
	    foreach (Transform ball in ballT)
        {
            ball.RotateAround(transform.position, Vector3.forward, 60 * Time.deltaTime);
        }
	}
}
