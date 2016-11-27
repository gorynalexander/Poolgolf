using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

    public GameObject resultWindow;
    public GUIText text;
    public Text text1;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            //text1.text = "ds";
            /*
            if (resultWindow.activeSelf == true)
            {
                resultWindow.SetActive(false);
            } else
            {
                resultWindow.SetActive(true);
            }
            */
        }
        
	}
}
