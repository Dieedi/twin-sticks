using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	public GameObject CurrentBall;

    private bool split = false;

	// Use this for initialization
	void Start () {
        new MyKeyFrame (0.1f, new Vector3 (1, 1, 1), new Quaternion (1f, 1f, 1f, 1f));
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log ("H " + CrossPlatformInputManager.GetAxis ("Horizontal"));
        Debug.Log ("V " + CrossPlatformInputManager.GetAxis ("Vertical"));

        split = CrossPlatformInputManager.GetButtonDown ("Fire1");
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")) {
            Debug.Log ("split !");
        }
	}

	void OnSplitBall () {
		Debug.Log ("split element");
	}
}
