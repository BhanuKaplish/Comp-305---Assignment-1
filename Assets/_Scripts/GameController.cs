using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    //Private Instance variables
    private int _scoreValue;
    private int _livesValue;

    //public Access methods
    //public int ScoreValue
    //Public Indtance Variables
    public int asteroidNumber = 3;
    public AsteroidController asteroid;

	// Use this for initialization
	void Start () {
        initialize();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Private method
    private void initialize()
    {
        for(int asteroidCount = 0; asteroidCount < this.asteroidNumber; asteroidCount++)
        {
            Instantiate(asteroid.gameObject);
        }
    }
}
