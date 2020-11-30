using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
  public GameObject astro;

  void Update()
  {
    if (astro.transform.position.x > transform.position.x + 10)
    {
      transform.position = new Vector3(astro.transform.position.x + 10, transform.position.y, transform.position.z);
    }
    if (astro.transform.position.x < transform.position.x - 10)
    {
      transform.position = new Vector3(astro.transform.position.x - 10, transform.position.y, transform.position.z);
    }
  }
}
