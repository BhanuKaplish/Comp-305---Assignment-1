﻿using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _asteroidSound;
    private AudioSource _coinSound;

    //Public Instance variables
    public GameController gameController; 
    
	// Use this for initialization
	void Start () {
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._asteroidSound = this._audioSources[1];
        this._coinSound = this._audioSources[2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Asteroid"))
        {
            this._asteroidSound.Play();
            this.gameController.livesValue -= 1;
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            this._coinSound.Play();
            this.gameController.ScoreValue += 100;
        }

    }
}
