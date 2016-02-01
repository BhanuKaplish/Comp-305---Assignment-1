using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

    //PUBLIC VARIABLES
    public float minVertSpeed = 5f;
    public float maxVertSpeed = 10f;
    public float minHoriSpeed = -2f;
    public float maxHoriSpeed = 2f;

    //PRIVATE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _verticalSpeed;
    private float _horizontalDrift;

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
        
        this._currentPosition -= new Vector2(this._verticalSpeed, this._horizontalDrift);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -1134)
        {
            this.Reset();
        }
    }

    void Reset()
    {
        float yPosition = Random.Range(-209f, 209f);
        this._transform.position = new Vector2(-422f, yPosition);
        this._verticalSpeed = Random.Range(this.minVertSpeed, this.maxVertSpeed);
        this._horizontalDrift = Random.Range(this.minHoriSpeed, this.maxHoriSpeed);
    }
}
