using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour {

    public Transform hand;
	// Use this for initialization
	void Start () {
        transform.SetParent(hand);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
