using UnityEngine;
using System.Collections;

public class CoinSpin : MonoBehaviour 
{

	public int rotX;
	public int rotY;
	public int rotZ;

	// Update is called once per frame
	void Update () 
	{
		if (this.gameObject != null) {
			this.gameObject.transform.Rotate (rotX, rotY, rotZ);
		}
	}

}
