using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;
    private Renderer renderer;
    private float lastHoverTime;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        startColor = renderer.material.color;
    }

    void OnMouseOver()
    {
        lastHoverTime = Time.time;
        renderer.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        renderer.material.color = startColor;
    }

    void Update()
    {
        if (Time.time - lastHoverTime > 5f)
        {
            renderer.material.color = Color.red;
        }
    }
}

