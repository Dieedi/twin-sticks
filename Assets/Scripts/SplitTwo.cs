using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitTwo : MonoBehaviour {

    [Tooltip("Offset between main ball and splited ball")]
    public float offset = 1;

    [Tooltip("Main ball")]
    public GameObject MainSphere;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 spherePosition = MainSphere.GetComponent<Transform> ().position;
        Vector3 newPosition = new Vector3 (spherePosition.x, spherePosition.y + offset, spherePosition.z);
        transform.position = newPosition;
        transform.rotation = MainSphere.GetComponent<Transform> ().rotation;
	}
}
