using UnityEngine.UI;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
  [SerializeField]
  private int CurrentHealthPoints;
  public int MaxHealthPoints = 3;


  public GameObject HealthBar1;

  public GameObject HealthBar2;

  public GameObject HealthBar3;

  void Start()
  {
    CurrentHealthPoints = MaxHealthPoints;
  }

  private void Update()
  {

  }

  public void ApplyDamage(int AmountOfDamage)
  {
    CurrentHealthPoints -= AmountOfDamage;
    if (CurrentHealthPoints == 2)
    {
      Destroy(HealthBar1);
    }
    if (CurrentHealthPoints == 1)
    {
      Destroy(HealthBar2);
    }
    if (CurrentHealthPoints == 0)
    {
      Destroy(HealthBar3);
    }
    if (CurrentHealthPoints <= 0)
    {
      Destroy(gameObject);
    }
  }

}
