using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject arrow;
    public Transform upArrow;
    public Transform downArrow;
    private Transform temp;
    public float speed;
    public static bool isStarted = false;
    private Rigidbody2D gmRigidbody;
    public float speedVal = 1f;
    public static bool canLose = false;
    private float startTime;
    public float timer;
    public AudioSource ballHit;
    public static int attempsCount = 0;



    void Start () {
        //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(1,1,0));
        temp = gameObject.transform;
        gmRigidbody = gameObject.GetComponent<Rigidbody2D>();
        isStarted = false;
        canLose = false;
    }
	

	// Update is called once per frame
	void Update () {

        speed = gmRigidbody.velocity.magnitude;

        if (Input.GetKeyDown("w"))
        {
            arrow.transform.position = upArrow.position;
            // this code for changing START speed +

        }
        if (Input.GetKeyDown("s"))
        {
            arrow.transform.position = downArrow.position;
            // this code for changing START speed -

        }

        if (Input.GetKey("d"))
        {
           // gameObject.transform.Rotate(new Vector3(0, 0, 0));
            arrow.transform.RotateAround(temp.position, new Vector3(0, 0, -1), 1);
        }
        if (Input.GetKey("a"))
        {
            // gameObject.transform.Rotate(new Vector3(0, 0, 0));
            arrow.transform.RotateAround(temp.position, new Vector3(0, 0, 1), 1);
        }

        if (Input.GetKeyDown("space"))
        {
            if (!isStarted)
            {
                ballHit.Play(0);
                gmRigidbody.AddForce((arrow.transform.position - gameObject.transform.position)*3);
                isStarted = true;
                arrow.SetActive(false);
                startTime = Time.time;
                attempsCount++;
            } 
            //gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(arrow.position, 0);
            // 
        }
        if (isStarted)
        {
            speedVal -= 0.05f * Time.deltaTime;
        }


        if (gmRigidbody.velocity.magnitude <= 0.8f && isStarted)
        {
            gmRigidbody.velocity = gmRigidbody.velocity.normalized * speedVal;
            speedVal -= 0.05f * Time.deltaTime;
        }
        if (gmRigidbody.velocity.magnitude <= 1.5 && gmRigidbody.velocity.magnitude >= 0.81f && isStarted)
        {
            gmRigidbody.velocity = gmRigidbody.velocity.normalized * speedVal;
            speedVal -= 0.05f * Time.deltaTime;
        }
        if (gmRigidbody.velocity.magnitude <= 0.4f && isStarted)
        {
            gmRigidbody.velocity = gmRigidbody.velocity.normalized * 0;

        }

        if (isStarted)
        {
            timer = Time.time - startTime;
            if (timer >= 3f) canLose = true;
        }

    }
}
