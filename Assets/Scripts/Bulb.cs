using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb : MonoBehaviour {

	public Sprite[] bulbFrames;
	public float deltaTime = 0.2f;

	private bool isOn = false;
	private int index = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Switch", 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Switch() {
		isOn = !isOn;
		index = isOn ? 1 : 0;
		
		transform.GetComponent<SpriteRenderer>().sprite = bulbFrames[index];
	}
}
