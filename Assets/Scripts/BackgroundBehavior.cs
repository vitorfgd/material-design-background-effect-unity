using UnityEngine;
using System.Collections;

public class BackgroundBehavior : MonoBehaviour {

	void Start () {
		LeanTween.scale (this.gameObject, new Vector2 (20f, 20f), 1f);
	}
}
