using UnityEngine;

/// <summary>
/// Klasse für die Generierung von Hindernissen
/// </summary>
public class PipeSpawn : MonoBehaviour {

	/// <summary>
	/// Prefab für die Hindernisse
	/// </summary>
	public GameObject pipe;

	/// <summary>
	/// Geklonte Instanz des Prefabs
	/// </summary>
	private GameObject pipeClone;

	/// <summary>
	/// Position der Hindernisse
	/// </summary>
	private Vector2 position;

	/// <summary>
	/// Intervall für die Generierung
	/// </summary>
	public float spawntime = 2f;

	/// <summary>
	/// Sekunden bis zur Deinitialisierung
	/// </summary>
	public float lifetime = 6f;

    public float minPosY = -2.1f;
    public float maxPosY = 0.9f;

	/// <summary>
	/// Startfunktion wird initial aufgerufen
	/// </summary>
	void Start() {
		InvokeRepeating("spawn",spawntime,spawntime);
	}


	/// <summary>
	/// Funktion für die Generierung der Prefab-Klone
	/// </summary>
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

	/// <summary>
	/// Funktion zum deinitialisieren der Gameobjekte
	/// </summary>
	void destroy(){
		//Klon nach x-Sekunden zerstören
		Destroy(pipeClone,lifetime);
	}
}
