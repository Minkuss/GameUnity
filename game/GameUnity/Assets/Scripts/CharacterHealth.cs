using UnityEngine.UI;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField]
    private int CurrentHealthPoints;
    public int MaxHealthPoints = 3;

    public GameObject UIHealthBar;
    private Text HealthBar;
    private RectTransform HealthBarPos;

    void Start()
    {
        HealthBar = UIHealthBar.GetComponent<Text>();
        HealthBarPos = UIHealthBar.GetComponent<RectTransform>();
        CurrentHealthPoints = MaxHealthPoints;
        HealthBar.text = CurrentHealthPoints.ToString();
    }

    private void Update() {
        HealthBarPos.position = new Vector2(transform.position.x, transform.position.y + 2.5f);
    }

    public void ApplyDamage(int AmountOfDamage) {
        CurrentHealthPoints -= AmountOfDamage;
        if (CurrentHealthPoints <= 0) {
            Destroy(gameObject);
        }
        HealthBar.text = CurrentHealthPoints.ToString();
    }

}
