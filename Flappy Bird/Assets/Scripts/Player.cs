using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Klasse für das Verhalten der Spielfigur und Kollisionen
/// </summary>
public class Player : MonoBehaviour{

    /// <summary>
	/// Vector2 für die Flugkraft der Spielfigur bei Touchinput
    /// </summary>
    public Vector2 flyForce = new Vector2();

	/// <summary>
	/// Text des Score User Interface
	/// </summary>
	private Text text;

	/// <summary>
	/// Variable um die Punktzahl hochzuzählen
	/// </summary>
	private int score;
   
	/// <summary>
	/// Startfunktion wird initial aufgerufen
	/// </summary>
    void Start(){
		//Text mit User Interface Komponente verknüpfen
		text = GameObject.Find("Text").GetComponent<Text>();
		//Startpositon der Spielfigur
        transform.position = new Vector2(-2f, 0f);
    }

    /// <summary>
    /// Updatefunktion wird pro Frame aufgerufen
    /// </summary>
    void Update(){
        
		// Inputabfrage
		if (Input.GetButtonDown("Fire1")){
            // Geschwindigkeit des Körpers auf den Nullvektor setzen
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            // Flugkraft zu dem Körper hinzufügen
			GetComponent<Rigidbody2D>().AddForce(flyForce);
        }
    }

	/// <summary>
	/// Funktion zum Abfangen einer Kollision mit einem Trigger Collider
	/// Erhöht die Punktzahl bei passieren der Röhren und aktualisiert die Punkteanzeige
	/// </summary>
	void OnTriggerEnter2D(Collider2D other){
		score++;
		text.text = "Score: "+score.ToString();
	}

	/// <summary>
	/// Funktion zum Abfangen einer Kollision(ohne Trigger)
	/// </summary>
	void OnCollisionEnter2D(Collision2D coll){
		// Prüfen ob Kollisionsobjekt den passenden Tag hat
		if(coll.gameObject.tag == "Obstacle"){
			SceneManager.LoadScene("GameOver");
		}
	}
}