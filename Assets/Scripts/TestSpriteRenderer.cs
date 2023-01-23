using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpriteRenderer : MonoBehaviour
{
    [SerializeField] Sprite burgerSprite;

    void Start()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = burgerSprite;
    }

    void Update()
    {

    }
}
