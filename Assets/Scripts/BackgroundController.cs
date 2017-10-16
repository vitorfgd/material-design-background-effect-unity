using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	private GameObject currentBackground, oldBackground;
	public GameObject [] possibleBackground;
	private int randomize;

	void Start () {
//		Invoke ("ChangeBackground", 0.2f);
		InvokeRepeating ("ChangeBackground", 0.2f, 1f);
	}

	public void ChangeBackground (){
		randomize = Random.Range (0, possibleBackground.Length);
		GameObject go = (GameObject) Instantiate (possibleBackground[randomize], Vector2.zero , Quaternion.identity);

		if (currentBackground != null){
			oldBackground = currentBackground;
			Destroy (oldBackground.gameObject);
		}

		currentBackground = go;
	}
}
