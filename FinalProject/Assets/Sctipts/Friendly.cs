using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Friendly : MonoBehaviour
{
  [SerializeField] private UnityEvent myTrigger;
  [SerializeField] private ParticleSystem heartParticle;
  [SerializeField] private bool isFriend = false;
  private void OnTriggerEnter2D(Collider2D other)
  {
    if (isFriend == false)
    {
      Instantiate(heartParticle, transform.position, heartParticle.transform.rotation);
      myTrigger.Invoke();
      isFriend = true;
    }
  }
}
