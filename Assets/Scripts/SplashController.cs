using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour {

    public byte alphaSpeed = 1;

    private Color32 splashColor;
    private Text splashText;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = GameObject.Find ("LevelManager").GetComponent<LevelManager> ();
        splashText = GetComponent<Text> ();
        splashColor = splashText.color;
        splashText.color = new Color32 (splashColor.r, splashColor.g, splashColor.b, 0);
	}
	
	// Update is called once per frame
	void Update () {
        splashColor.a += alphaSpeed;
        splashText.color = new Color32 (splashColor.r, splashColor.g, splashColor.b, splashColor.a);

        if (splashColor.a >= byte.MaxValue) {
            levelManager.StartFade ();
        }
	}
}
