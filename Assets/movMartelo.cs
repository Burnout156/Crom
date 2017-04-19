using UnityEngine;
using System.Collections;

public class movMartelo : MonoBehaviour {
    
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Inimigo")
		{
			Destroy(col.gameObject);
		}
	}
// Use this for initialization
 void Start() { 

	}
	
	// Update is called once per frame
	void Update () {
	
	}

}