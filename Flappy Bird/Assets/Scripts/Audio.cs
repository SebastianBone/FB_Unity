using UnityEngine;

public class Audio : MonoBehaviour {

    
	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
}
