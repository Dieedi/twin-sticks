using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    private bool split = false;
    private GameObject SplitTwo;

	// Use this for initialization
	void Start () {
        new MyKeyFrame (0.1f, new Vector3 (1, 1, 1), new Quaternion (1f, 1f, 1f, 1f));

        SplitTwo = GameObject.Find ("SplitTwo");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log ("H " + CrossPlatformInputManager.GetAxis ("Horizontal"));
        Debug.Log ("V " + CrossPlatformInputManager.GetAxis ("Vertical"));

        split = CrossPlatformInputManager.GetButtonDown ("Fire1");
        if (split) {
            Debug.Log ("split !");
            SplitTwo.GetComponentInChildren<MeshRenderer> ().enabled = true;
            SplitTwo.GetComponentInChildren<SphereCollider> ().enabled = true;
            GameObject.Find ("RollerBall").GetComponent<MeshRenderer> ().enabled = false;
            GameObject.Find ("RollerBall").GetComponent<SphereCollider> ().enabled = false;
        }
	}
}
