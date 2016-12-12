using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Paddle paddle;
    private bool gameStarted = false;
    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
        
    }

    // Update is called once per frame
    void Update () {
        if (!gameStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
            if (Input.GetMouseButtonDown(0))
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 10);
                gameStarted = true;
            }
        }
       
	
	}
}
