using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	
	private const float ITEMS = 10.0f;
	private static float xVal = ITEMS * -.5f;
	private static GameObject go;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < ITEMS; i++) {
			Vector3 initPos = new Vector3(xVal, .5f, 0.0f);
			float iRand = Random.Range (0.0f, 20.0f);
			go = Resources.Load ("sortItem") as GameObject;
			go.transform.localScale = new Vector3(1, iRand, 1);
			Instantiate(go, initPos,Quaternion.identity);
			xVal += 3;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
