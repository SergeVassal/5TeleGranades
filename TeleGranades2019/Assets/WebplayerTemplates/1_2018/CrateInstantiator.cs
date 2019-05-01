using UnityEngine;
using System.Collections;

public class CrateInstantiator : MonoBehaviour {

	public GameObject crateHere;
	public int columns;
	public int rows;

	public float spaceHor;
	public float spaceVert;

	void Start () {
		Vector3 xPos=new Vector3 (-10f, 0f, 0f);
		float spaceHorHolder=spaceHor;
		for (int r = 0; r < rows; r++) {
			spaceHor = spaceHorHolder;
			for (int c = 0; c < columns; c++) {				
				Instantiate(crateHere,new Vector3(xPos.x+c+spaceHor,r+spaceVert,0f),Quaternion.identity);
				spaceHor = spaceHor+spaceHorHolder;
			}
		}
	
	}
	


}
