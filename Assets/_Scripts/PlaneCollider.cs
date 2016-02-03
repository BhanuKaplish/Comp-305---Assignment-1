using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _asteroidSound;
    private AudioSource _coinSound;
    
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
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            this._coinSound.Play();
            Debug.Log("Coin sound");
        }
    }
}
