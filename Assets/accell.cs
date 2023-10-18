using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accell : MonoBehaviour
{
	public Rigidbody2D rb;
	float dirX;
	float dirY;
	float moveSpeed = 20f;

	public GameObject text;

	public bool gamestart;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		gamestart = false;
		rb.constraints = RigidbodyConstraints2D.FreezeAll;
	}
	
	// Update is called once per frame
	void Update () {
		dirX = Input.acceleration.x * moveSpeed;
		dirY = Input.acceleration.y * moveSpeed;
	}

	void FixedUpdate()
	{
		if(gamestart)
		{
			rb.AddForce(new Vector2(dirX,0));
			rb.constraints = RigidbodyConstraints2D.None;
		}else if(Input.touchCount >= 1){
			gamestart = true;
			Object.Destroy(text);
		}
			
	}

}
