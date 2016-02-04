using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDFPS : MonoBehaviour{
   

    public float frequency = 0.5F; // The update frequency of the fps
    public int nbDecimal = 1; // How many decimal do you want to display

    private float accum = 0f; // FPS accumulated over the interval
    private int frames = 0; // Frames drawn over the interval
    private Text text; // The fps formatted into a string.

    void Start(){
        text = GameObject.Find("FPS").GetComponent<Text>();
        StartCoroutine(FPS());
    }

    void Update(){
        accum += Time.timeScale / Time.deltaTime;
        ++frames;
    }

    IEnumerator FPS(){
       
        // Infinite loop executed every "frenquency" secondes.
        while (true){
           
            // Update the FPS
            float fps = accum / frames;
            text.text = fps.ToString("f" + Mathf.Clamp(nbDecimal, 0, 10));
       
            accum = 0.0F;
            frames = 0;

            yield return new WaitForSeconds(frequency);
        }
    }
}