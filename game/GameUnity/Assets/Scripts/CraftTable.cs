using UnityEngine;
using UnityEngine.UI;

public class CraftTable : MonoBehaviour
{
  public GameObject interactiveButton;
  public GameObject tableScreen;

  private void OnTriggerEnter2D(Collider2D other)
  {
    interactiveButton.SetActive(true);
  }
  private void OnTriggerExit2D(Collider2D other)
  {
    interactiveButton.SetActive(false);
    tableScreen.SetActive(false);
  }

}
