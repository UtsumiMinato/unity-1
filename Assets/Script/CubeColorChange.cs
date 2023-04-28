using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;
    private Renderer renderer;
    private float lastHoverTime;
    public float time = 5f;

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
        if (Time.time - lastHoverTime > time)
        {
            renderer.material.color = Color.red;
        }
    }
}

