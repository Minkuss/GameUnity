using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingcameraScene : MonoBehaviour
{
  public GameObject ship;

  void Update()
  {
    if (ship.transform.position.x >= 38.94019)
    {
      transform.position = new Vector3(ship.transform.position.x + 10, transform.position.y, -42);
    }

  }
}
