using UnityEngine;
using System.Collections;

public class TeleporterScript : MonoBehaviour {

	public GameObject player;
	Rigidbody rBody;
	CapsuleCollider capsule;
	bool tossed=false;

	void Start () {
		rBody = GetComponent<Rigidbody> ();
		capsule = GetComponent<CapsuleCollider> ();	
	}	

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			return;
		}
		rBody.velocity = Vector3.zero;
		tossed = true;
		capsule.enabled = true;
	}

	void OnCollisionEnter(Collision col){
		tossed = false;
		player.transform.position = new Vector3 (transform.position.x, transform.position.y + 1f, transform.position.z);
		capsule.enabled = false;
		gameObject.SetActive (false);
		Debug.Log ("col");
	}
}
