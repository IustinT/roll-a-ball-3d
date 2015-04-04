using UnityEngine;
using System.Collections;

public class SpeedSpriteControler : MonoBehaviour {

    private float ballSpeed;
    PlayerControler PC;

	// Use this for initialization
    void Start()
    {
        PC = GameObject.Find("Player Controler").GetComponent<PlayerControler>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
