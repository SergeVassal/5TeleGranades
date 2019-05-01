using UnityEngine;
using System.Collections;

public class TosserScript : MonoBehaviour {

	public GameObject objToToss;
	public Transform tossPoint;

	private Rigidbody rBody;
	private GameObject obj;


	void Start () {		
		obj = (GameObject)Instantiate (objToToss);
		rBody = obj.GetComponent<Rigidbody> ();
		obj.SetActive (false);
		obj.GetComponent<TeleporterScript> ().player = gameObject;
	}
	

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			FireFunc ();
		}	
	}

	void FireFunc (){
		rBody.velocity = Vector3.zero;
		obj.transform.position = tossPoint.position;
		obj.transform.rotation = Quaternion.identity;
		obj.SetActive (true);
		rBody.AddForce (tossPoint.transform.forward * 10f, ForceMode.Impulse);
	}
}
