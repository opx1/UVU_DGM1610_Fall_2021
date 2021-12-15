using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class XColorChange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Image blue;
    public Image green;
    public Image yellow;
    public Image pink;
    public TextMeshProUGUI youWin;
    

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        youWin.gameObject.SetActive(false);
    }

    public void ColorPink()
    {
        spriteRenderer.color = new Color(1f, .75f, 0.9349332f, 1f);
        pink.gameObject.SetActive(true);
    }

    public void ColorYellow()
    {
        spriteRenderer.color = new Color(0.9719199f, 1f, 0.6196079f, 1f);
        yellow.gameObject.SetActive(true);
    }

    public void ColorBlue()
    {
        spriteRenderer.color = new Color(.6179246f, .9547542f, 1f, 1f);;
        Debug.Log(spriteRenderer.color);
        blue.gameObject.SetActive(true);
    }

    public void ColorGreen()
    {
        spriteRenderer.color = new Color(0.6179246f, 1f, 0.6883069f, 255f);
        green.gameObject.SetActive(true);
    }
}