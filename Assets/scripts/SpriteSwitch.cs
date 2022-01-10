using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitch : MonoBehaviour
{
    // Start is called before the first frame update
public SpriteRenderer spriteRenderer;
public Sprite newSprite, circle;


   
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = circle;
    }
   
void Update () {
		if (Input.GetMouseButtonDown(0)) {
			spriteRenderer.sprite = newSprite; 
		}
	}
}