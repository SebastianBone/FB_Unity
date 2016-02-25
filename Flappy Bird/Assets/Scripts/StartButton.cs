using UnityEngine;
using UnityEngine.SceneManagement;
// Klasse für den Start Button
public class StartButton : MonoBehaviour {
	// Updatefunktion wird pro Frame aufgerufen
	void Update () {
		// Bei Touchinput
		if(Input.touchCount == 1){
			//Vector3 Inputposition
			Vector3 position3D = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			// Überführung in 2D Position
			Vector2 position2D = new Vector2(position3D.x, position3D.y);
			//Abfrage ob Inputposition mit Kollisionsboxposition übereinstimmt
			if(transform.GetComponent<Collider2D>() == Physics2D.OverlapPoint(position2D)){
				//Laden der Spielscene
				SceneManager.LoadScene("Game");
			}
		}
	}
}