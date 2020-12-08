using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
  public GameObject astro;

  void Update() {
    if (astro != null) {
      CheckPositionX();
      CheckPositionY();
    }
  }

  private void CheckPositionX() {
    if (astro.transform.position.x > transform.position.x + 10)
      transform.position = new Vector3(astro.transform.position.x + 10, transform.position.y, transform.position.z);
    if (astro.transform.position.x < transform.position.x - 10)
      transform.position = new Vector3(astro.transform.position.x - 10, transform.position.y, transform.position.z);
  }

  private void CheckPositionY() {
    if (astro.transform.position.y > transform.position.y + 5)
        transform.position = new Vector3(transform.position.x, transform.position.y  +  5, transform.position.z);
      if (astro.transform.position.y < transform.position.y - 5)
        transform.position = new Vector3(transform.position.x, transform.position.y - 5, transform.position.z);
  }
}