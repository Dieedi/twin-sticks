using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class MyKeyFrame {

    private float time;
    private Vector3 pos;
    private Quaternion rot;

    public MyKeyFrame (float frameTime, Vector3 framePos, Quaternion frameRot) {
        time = frameTime;
        pos = framePos;
        rot = frameRot;

        Debug.Log ("time : " + time + ", pos : " + pos + ", rot : " + rot);

    }
}
