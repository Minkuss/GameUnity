using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftTableInterfaseScript : MonoBehaviour
{
  void Start()
  {
    gameObject.SetActive(false);
  }

  public void visibility()
  {
    if (gameObject.activeSelf == false)
    {
      gameObject.SetActive(true);
    }
    else
    {
      gameObject.SetActive(false);
    }
  }
}
