using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
    // Player is a container of Ball, not the Ball itself

    public GameObject UnSplitBall;
    public GameObject SplitTwoBall;

    private bool split = false;
    private GameObject CurrentBall;
    private const float k_GroundRayLength = 1f; // The length of the ray to check if the ball is grounded.

	// Use this for initialization
	void Start () {
        new MyKeyFrame (0.1f, new Vector3 (1, 1, 1), new Quaternion (1f, 1f, 1f, 1f));

        // First ball will always be the unsplit
        CurrentBall = gameObject.transform.GetChild (0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if ((CrossPlatformInputManager.GetButtonDown ("Fire1") && !IsGrounded ())
            || (split && IsGrounded ())) {
            OnChangeForm ();
        }
	}

    private bool IsGrounded () {
        return Physics.Raycast (CurrentBall.transform.position, -Vector3.up, k_GroundRayLength, LayerMask.GetMask ("Default", "Ground"));
    }

    private void OnChangeForm () {
        Vector3 currentPos = CurrentBall.transform.position;
        Vector3 currentVel = CurrentBall.GetComponent<Rigidbody> ().velocity;
        Quaternion currentRot = CurrentBall.transform.rotation;
        Destroy (CurrentBall);

        CurrentBall = Instantiate (split ? UnSplitBall : SplitTwoBall, currentPos, currentRot, transform);
        CurrentBall.GetComponent<Rigidbody> ().velocity = currentVel;

        split = !split;
	}
}
