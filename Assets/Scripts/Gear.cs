using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour {

  public readonly float[] SCALE = { 
		2.0f, 2.0f, 2.0f, 2.0f, 
		1.75f, 1.75f, 1.75f,
		1.75f, 1.75f, 1.75f,
		1.5f, 1.5f, 1.5f, 
		1.25f, 1.25f, 1.25f, 1.25f 
	};

	public Sprite[] numberFrames;

  private Transform goNumber;
	private int index = 10;

	// Use this for initialization
	void Start () {
    goNumber = transform.Find("Number");
	}
	
	// Update is called once per frame
	void Update () {
    if (goNumber != null) {
		  goNumber.GetComponent<SpriteRenderer>().sprite = numberFrames[index];
			goNumber.localScale = new Vector3(SCALE[index], SCALE[index], goNumber.localScale.z);
    }
	}
}
