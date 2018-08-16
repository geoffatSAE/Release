using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Releaser : MonoBehaviour {

    public GameObject canvas;
    public GameObject release;
    public CanvasGroup main;
    public CanvasGroup second;
    public float mainalpha;
    public float secondalpha;
    public GameObject fader;
    public AudioSource music;
    private float musicTime;


	// Use this for initialization
	void Start () {

        mainalpha = canvas.GetComponent<CanvasGroup>().alpha;
        secondalpha = release.GetComponent<CanvasGroup>().alpha;
        musicTime = music.volume;
    }
	
	// Update is called once per frame
	void Update () {

        mainalpha = canvas.GetComponent<CanvasGroup>().alpha;
        secondalpha = release.GetComponent<CanvasGroup>().alpha;

        release.SetActive(true);
        if (release.GetComponent<UIFader>().enabled == true)
        {

        }
        else if (secondalpha == 1f)
        {
            StartCoroutine(Releasing());
            StartCoroutine(Fader());
        }
       
	}

    IEnumerator Releasing()
    {
        yield return new WaitForSecondsRealtime(8);
        release.GetComponent<UIFader>().enabled = true;
    }

    IEnumerator Fader()
    {
        yield return new WaitForSecondsRealtime(80);
        musicTime -= Time.deltaTime / 4;
        fader.SetActive(true);
        music.volume = musicTime;
        yield return new WaitForSecondsRealtime(7);
        Application.Quit();
        
    }
}
