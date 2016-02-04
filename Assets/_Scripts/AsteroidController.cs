using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

    //PUBLIC VARIABLES
    public float minVertSpeed = 7f;
    public float maxVertSpeed = 10f;
    public float minHoriSpeed = -2f;
    public float maxHoriSpeed = 2f;

    //PRIVATE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _horizontalSpeed;
    private float _verticalDrift;

    // Use this for initialization
    void Start()
    {
        //Making a refernce with the Transform component 
        this._transform = gameObject.GetComponent<Transform>();

        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        
        this._currentPosition -= new Vector2(this._horizontalSpeed, this._verticalDrift);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -364)
        {
            this.Reset();
        }
    }

    void Reset()
    {
        float yPosition = Random.Range(-209f, 209f);
        this._transform.position = new Vector2(600f, yPosition);
        this._horizontalSpeed = Random.Range(this.minVertSpeed, this.maxVertSpeed);
        this._verticalDrift = Random.Range(this.minHoriSpeed, this.maxHoriSpeed);
    }
}
