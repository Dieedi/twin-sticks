using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Animator anim;
    public Image fader;

    private int currentScene;

	// Use this for initialization
	void Start () {
        currentScene = SceneManager.GetActiveScene ().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void LoadNextScene () {
        SceneManager.LoadScene (currentScene + 1);
    }

    public void StartFade () {
        StartCoroutine (Fading ());
    }

    IEnumerator Fading () {
        anim.SetBool ("Fade", true);
        yield return new WaitUntil (() => fader.color.a >= 0.8f);
        SceneManager.LoadScene (currentScene + 1);
        anim.SetBool ("Fade", false);
    }
}
