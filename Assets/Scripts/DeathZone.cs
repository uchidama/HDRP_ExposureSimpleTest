using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		print ("Destroy");
		Destroy(other.gameObject);
	}

}
