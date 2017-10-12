using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faderController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void HideFader () {
        GetComponent<RectTransform> ().anchorMax = new Vector2 (0, 0);
        GetComponent<RectTransform> ().sizeDelta = new Vector2 (0, 0);
    }
}
