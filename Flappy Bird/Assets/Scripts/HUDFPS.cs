using UnityEngine;
using System.Collections;
using UnityEngine.UI;
// Klasse für die Darstellung der Frames pro Sekunde
public class HUDFPS : MonoBehaviour{
    // Interval der Aktualisierung der Darstellung
    public float interval = 0.5F; 
    // Dezimalstellen nach dem Komma
    public int decimalValues = 1; 
    // Timer
    private float timer = 0f; 
    // Gezeichnete Frames pro interval
    private int frames = 0; 
    // Text für die Darstellung im User Interface
    private Text text; 
    // Initiale Methode bei Start
    void Start(){
        // Verweis auf UI Komponente
        text = GameObject.Find("FPS").GetComponent<Text>();
        // Sequentieller Aufruf der Methode ohne den Spielfluss zu blockieren
        StartCoroutine(FPS());
    }
    // Update pro Frame
    void Update(){
        // Vergangene Zeit pro Frame
        timer += Time.timeScale / Time.deltaTime;
        // Frameanzahl erhöhen
        frames++;
    }
    // Sequentielle Methode
    IEnumerator FPS(){
        // Endlosschleife
        while (true){
            // Frames pro Sekunde errechnen
            float fps = timer / frames;
            // Übertragung an den Text und eingrenzen der Darstellung
            text.text = fps.ToString("f" + Mathf.Clamp(decimalValues, 0, 10));
            // Werte reset
            timer = 0.0F;
            frames = 0;
            // return interval
            yield return new WaitForSeconds(interval);
        }
    }
}