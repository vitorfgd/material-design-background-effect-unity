using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	private GameObject currentBackground, oldBackground;
	public GameObject [] possibleBackground;
	private int randomize;

	void Start () {
		Invoke ("ChangeBackground", 0.5f);
	}

	public void ChangeBackground (){
		randomize = Random.Range (0, possibleBackground.Length);
		GameObject go = (GameObject) Instantiate (possibleBackground[randomize], new Vector2 (0f, 5f), Quaternion.identity);

		if (currentBackground != null){
			oldBackground = currentBackground;
			Destroy (oldBackground.gameObject);
		}

		currentBackground = go;
	}
}
