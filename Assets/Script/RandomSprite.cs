using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public List<Sprite> sprites;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        int index = Random.Range(0, sprites.Count - 1);
        spriteRenderer.sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
