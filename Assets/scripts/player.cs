using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float player_speed;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		//targetPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		
		player_speed = Input.GetAxis("Vertical");
		anim.SetFloat("speed",player_speed);
			
	}

	private void LateUpdate() {
		
	}
}
