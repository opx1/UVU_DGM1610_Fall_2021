using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
  private SpriteRenderer spriteRenderer;

  private void Start()
  {
    spriteRenderer = GameObject.Find("Friendly").GetComponent<SpriteRenderer>();
  }

  public void ColorPink()
  {
    spriteRenderer.color = new Color(1f, .75f, 0.9349332f, 1f);
  }

  public void ColorYellow()
  {
    spriteRenderer.color = new Color(0.9719199f, 1f, 0.6196079f, 1f);
  }

  public void ColorBlue()
  {
    Color blue = new Color(.6179246f, .9547542f, 1f, 1f);
    spriteRenderer.color = blue;
    Debug.Log(spriteRenderer.color);
  }

  public void ColorGreen()
  {
    spriteRenderer.color = new Color(0.6179246f, 1f, 0.6883069f, 255f);
  }
  
  
}
