using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {
    public GameObject point;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //gameObject.transform.RotateAround(new Vector3(point.transform.position.x, point.transform.position.y, point.transform.position.z), new Vector3(0,0,-1), Mathf.SmoothStep(0, 90, Time.deltaTime * 2));
	}

    private int force = 50;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Debug.Log("HUI");
            col.gameObject.GetComponent<Rigidbody>().AddForce(force, force, 0);
        }
    }
}
