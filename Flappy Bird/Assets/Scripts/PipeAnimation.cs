using UnityEngine;

/// <summary>
/// Klasse für die Bewegung der Hindernisse
/// </summary>
public class PipeAnimation : MonoBehaviour {

	//Position der Hindernisse
	Vector2 position;

	//Geschwindigkeit der Hindernisse
	float speed = 0.1f;

	// Startfunktion wird initial aufgerufen
	void Start(){
		position = transform.position;
		InvokeRepeating("animate",0,0.033f);
	}

	/// <summary>
	/// Updatefunktion wird pro Frame aufgerufen
	/// </summary>
	void Update () {
		
		//position.x -= speed;
		//transform.position = position;

	}

	void animate(){
		position.x -= speed;
		transform.position = position;

	}
}
