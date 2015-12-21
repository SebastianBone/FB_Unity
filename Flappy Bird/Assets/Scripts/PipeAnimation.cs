using UnityEngine;

/// <summary>
/// Klasse für die Bewegung der Hindernisse
/// </summary>
public class PipeAnimation : MonoBehaviour {

	//Position der Hindernisse
	Vector2 position;

	//Geschwindigkeit der Hindernisse
	public float speed = 0.1f;

	// Startfunktion wird initial aufgerufen
	void Start(){
		position = transform.position;
		InvokeRepeating("animate",0,0.033f);
	}
		
	/// <summary>
	/// Animate the Pipe
	/// </summary>
	void animate(){
		position.x -= speed;
		transform.position = position;

	}
}
