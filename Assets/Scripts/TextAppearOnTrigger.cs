using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppearOnTrigger : MonoBehaviour 
{

    public Renderer rend;
    public Renderer textRend;
    public GameObject text;
    void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			rend = GetComponent<Renderer> ();
			rend.enabled = true;
            text = rend.transform.Find("TextMesh").gameObject;
            textRend = text.GetComponent<Renderer>();
            textRend.enabled = true;
            // Debug.Log ("Renderer enabled");
        }
    }

	void OnTriggerExit (Collider other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			rend = GetComponent<Renderer>();
			rend.enabled = false;
            text = rend.transform.Find("TextMesh").gameObject;
            textRend = text.GetComponent<Renderer>();
            textRend.enabled = false;
            // Debug.Log ("Renderer disabled");
        }
    }
}