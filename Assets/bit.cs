using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public bool state = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateColor();
    }

    void OnMouseDown()
    {
        state = !state;
        UpdateColor();
    }

    void UpdateColor()
    {
        spriteRenderer.color = state ? Color.blue : Color.red;
    }
}
