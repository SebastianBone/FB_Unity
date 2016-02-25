using UnityEngine;
// Klasse für die Bewegung der Hindernisse
public class PipeAnimation : MonoBehaviour {
	//Position der Hindernisse
	Vector2 position;
	//Geschwindigkeit der Hindernisse
	public float speed = 0.1f;
	// Startfunktion wird initial aufgerufen
	void Start(){
        // Ausgangsposition übergeben
		position = transform.position;
        // Intervall Aufruf der animate-Methode
		InvokeRepeating("animate",0,0.033f);
	}
	// Animate the Pipe
	void animate(){
        // Positionsveränderung in X-Richtung
		position.x -= speed;
        // Neue Position übergeben
		transform.position = position;
	}
}