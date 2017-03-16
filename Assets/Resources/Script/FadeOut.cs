using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {
    public static int fadeOutTime = 30;
    private int frame = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        frame++;
        if (frame > fadeOutTime) {
            return;
        }
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Color color = renderer.color;
        color.a += 1.0f / fadeOutTime;
        renderer.color = color;
	}
}
