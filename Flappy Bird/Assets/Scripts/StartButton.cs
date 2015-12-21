using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Klasse für den Start Button
/// </summary>
public class StartButton : MonoBehaviour {

	/// <summary>
	/// Updatefunktion wird pro Frame aufgerufen
	/// </summary>
	void Update () {
	
		//TODO: Debug Part!
		// Bei Mausklick
		if(Input.GetMouseButtonDown(0)){

			//Vector3 Inputposition
			Vector3 position3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			// Überführung in 2D Position
			Vector2 positon2D = new Vector2(position3D.x, position3D.y);
			//Abfrage ob Inputposition mit Kollisionsboxposition übereinstimmt
			if(transform.GetComponent<Collider2D>() == Physics2D.OverlapPoint(positon2D)){
				//Laden der Spielscene
				SceneManager.LoadScene("Game");
			}
		}

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
