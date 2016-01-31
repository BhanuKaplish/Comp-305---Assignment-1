using UnityEngine;
using System.Collections;

public class SkyController : MonoBehaviour {
    //PUBLIC VARIABLES
    public float speed = 5;

    //PRIVATE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
        //Making a refernce with the Transform component 
        this._transform = gameObject.GetComponent<Transform>();

        this.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        if(this._currentPosition.x <= -890)
        {
            this.Reset();
        }
	}

    void Reset()
    {
        this._transform.position = new Vector2(-668f, 0);
    }
}
