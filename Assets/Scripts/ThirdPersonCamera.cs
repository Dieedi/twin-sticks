using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 4.0f;
    private float sensitivityY = 1.0f;

	// Use this for initialization
	void Start () {
        camTransform = transform;
        cam = Camera.main;
        Transform[] playerTransforms = GameObject.Find ("Player").GetComponentsInChildren<Transform> ();
        Transform ballTransform = playerTransforms [1];
        lookAt = ballTransform;
	}
	
	// Update is called once per frame
    void Update () {
        Transform[] playerTransforms = GameObject.Find ("Player").GetComponentsInChildren<Transform> ();
        Transform ballTransform = playerTransforms [1];
        lookAt = ballTransform;
	}

    void LateUpdate () {
        Vector3 dir = new Vector3 (distance, 0, 0);
        Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
    }
}
