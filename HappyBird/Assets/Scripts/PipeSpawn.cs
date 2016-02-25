using UnityEngine;
// Klasse für die Generierung von Hindernissen
public class PipeSpawn : MonoBehaviour {
	// Prefab für die Hindernisse
	public GameObject pipe;
	// Instanz des Prefabs
	private GameObject pipeClone;
	// Position der Hindernisse
	private Vector2 position;
	// Intervall für die Generierung
	public float spawntime = 2f;
	// Sekunden bis zur Deinitialisierung
	public float lifetime = 6f;
    // Minimale Position in Y-Richtung
    public float minPosY = -2.1f;
    // Maximale Position in Y-Richtung
    public float maxPosY = 0.9f;
	// Startfunktion wird initial aufgerufen
	void Start() {
        // Intervall Aufruf der spawn-Methode
		InvokeRepeating("spawn",spawntime,spawntime);
	}
	// Funktion für die Generierung der Prefab-Klone
	void spawn(){
		//X-Position auf Gameobjekt Position setzen
		position.x = transform.position.x;
		//Y-Position Random in einer Range generieren
		position.y = Random.Range(minPosY, maxPosY);
		//Gameobjekt erzeugen
		pipeClone = (GameObject)Instantiate(pipe, position, transform.rotation);
		//deinitialisieren des Gameobjekts
		destroy();
	}
	// Funktion zum deinitialisieren der Gameobjekte
	void destroy(){
		//Klon nach x-Sekunden zerstören
		Destroy(pipeClone,lifetime);
	}
}