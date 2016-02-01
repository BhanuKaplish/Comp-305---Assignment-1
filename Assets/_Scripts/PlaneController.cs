using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

    //Private INSTANCE VARIABLES
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    //Public INSTANCE VARIABLES
    public float speed = 5f;


    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        this._currentPosition = this._transform.position;

        this._playerInput = Input.GetAxis("Horizontal");
        if(this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }
        this._checkBoundsLeftRight();

        this._playerInput = Input.GetAxis("Vertical");
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(0, this.speed);
        }

        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }
        this._checkBoundsTopBottom();

        this._transform.position = this._currentPosition;
    }



    //Private method for left right
    private void _checkBoundsLeftRight()
    {
        // check if plane is going out of left boundary
        if (this._currentPosition.x < -1036)
        {
            this._currentPosition.x = -1036;
        }

        // check if plane is going out of right boundary
        if (this._currentPosition.x > -516)
        {
            this._currentPosition.x = -516;
        }
    }

    //Private method for top bottom
    private void _checkBoundsTopBottom()
    {
        // check if plane is going out of left boundary
        if (this._currentPosition.y < -201)
        {
            this._currentPosition.y = -201;
        }

        // check if plane is going out of right boundary
        if (this._currentPosition.y > 201)
        {
            this._currentPosition.y = 201;
        }
    }
}
