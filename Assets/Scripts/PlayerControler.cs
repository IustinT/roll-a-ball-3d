using System.Collections;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
	public float speed;
	public GUIText ballMovement;
	private GameControler GC;

	void Start ()
	{
		GC = GameObject.Find ("Game Controler").GetComponent<GameControler> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
		GetComponent<Rigidbody> ().AddForce (movement * speed * Time.deltaTime);

		ballMovement.text = "Speed: " + GetComponent<Rigidbody> ().velocity.magnitude.ToString ("0.00") + "m/s";
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "PickUp") {		
			other.gameObject.SetActive (false);
			//GC.Count = 1;
			//GC.SetCountText ();
			IncrementScore ();
		}
	}

	void IncrementScore ()
	{
		GC.IncrementScore ();
	}





}