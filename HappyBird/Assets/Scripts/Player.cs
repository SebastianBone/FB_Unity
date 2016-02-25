using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Klasse für das Verhalten der Spielfigur
public class Player : MonoBehaviour{
	// Vector2 für die Flugkraft der Spielfigur bei Touchinput
    public Vector2 flyForce = new Vector2();
	// Text des Score im User Interface
	private Text text;
	// Variable um die Punktzahl hochzuzählen
	private int score;
	// Startfunktion wird initial aufgerufen
    void Start(){
		//Text mit User Interface Komponente verknüpfen
		text = GameObject.Find("Text").GetComponent<Text>();
		//Startpositon der Spielfigur
        transform.position = new Vector2(-2f, 0f);
    }
    // Updatefunktion wird pro Frame aufgerufen
    void Update(){
		// Inputabfrage
		if (Input.GetButtonDown("Fire1")){
            // Geschwindigkeit des Körpers auf den Nullvektor setzen
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            // Flugkraft zu dem Körper hinzufügen
			GetComponent<Rigidbody2D>().AddForce(flyForce);
        }
    }
	// Funktion zum Abfangen einer Kollision mit einem Trigger Collider
	// Erhöht die Punktzahl bei passieren der Röhren und aktualisiert die Punkteanzeige
	void OnTriggerEnter2D(Collider2D other){
		score++;
		text.text = score.ToString();
	}
	// Funktion zum Abfangen einer Kollision(ohne Trigger)
	void OnCollisionEnter2D(Collision2D coll){
		// Prüfen ob Kollisionsobjekt den passenden Tag hat
		if(coll.gameObject.tag == "Obstacle"){
			SceneManager.LoadScene("GameOver");
		}
	}
}