using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScriptY : MonoBehaviour
{
  public GameObject astro;

  void Update()
  {
    if (astro.transform.position.y > transform.position.y + 5)
    {
      transform.position = new Vector3(transform.position.x, transform.position.y  +  5, transform.position.z);
    }
    if (astro.transform.position.y < transform.position.y - 5)
    {
      transform.position = new Vector3(transform.position.x, transform.position.y - 5, transform.position.z);
    }
  }
}