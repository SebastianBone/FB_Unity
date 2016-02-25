using UnityEngine;
// Klasse für die Hintergrundmusik
public class Audio : MonoBehaviour {
	// Initialer Aufruf bei Start
	void Awake () {
        //Zustand soll bei Szenenwechsel erhalten bleiben
        DontDestroyOnLoad(transform.gameObject);
	}
}