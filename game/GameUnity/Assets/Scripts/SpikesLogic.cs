using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesLogic : MonoBehaviour
{
    public int Damage = 1;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<CharacterHealth>().ApplyDamage(Damage);
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2f), ForceMode2D.Impulse);
        }
    }
}
