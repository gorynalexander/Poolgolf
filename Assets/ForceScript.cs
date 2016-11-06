using UnityEngine;
using System.Collections;

public class ForceScript : MonoBehaviour {

    public Transform arrow;
    private Transform temp;

    // Use this for initialization
    void Start () {
        //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(1,1,0));
        temp = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
        {
           // gameObject.transform.Rotate(new Vector3(0, 0, 0));
            arrow.RotateAround(temp.position, new Vector3(0, 0, -1), 1);
        }
        if (Input.GetKey("a"))
        {
            // gameObject.transform.Rotate(new Vector3(0, 0, 0));
            arrow.RotateAround(temp.position, new Vector3(0, 0, 1), 1);
        }

        if (Input.GetKeyDown("space"))
        {
            // gameObject.transform.Rotate(new Vector3(0, 0, 0));
            transform.LookAt(arrow);
            //gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(arrow.position, 0);

            // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(arrow.position.x, arrow.position.y*-1));

        }





    }
}
