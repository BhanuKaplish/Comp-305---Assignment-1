using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
    //Private Instance variables
    private int _scoreValue;
    private int _livesValue;

    //public Access methods
    public int ScoreValue
    {
        get {
            return _scoreValue;
        }
        set {
            
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }
    public int livesValue
    {
        get
        {
            return _livesValue;
        }
        set
        {
            Debug.Log(this._livesValue);
            this._livesValue = value;
            this.LivesLabel.text = "Lives: " + this._livesValue;
        }
    }
    //Public Instance Variables
    public int asteroidNumber = 4;
    public AsteroidController asteroid;
    public Text LivesLabel;
    public Text ScoreLabel;

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
        this._livesValue = 5;
        this._scoreValue = 0;
        for(int asteroidCount = 0; asteroidCount < this.asteroidNumber; asteroidCount++)
        {
            Instantiate(asteroid.gameObject);
        }
    }
}
