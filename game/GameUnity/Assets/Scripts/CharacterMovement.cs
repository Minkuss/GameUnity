using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float WalkSpeed;
    public float HorizontalDirection = 0.08f;
    public float JumpForce = 10f;
    [SerializeField] private bool IsGrounded;
    
    private Rigidbody2D PlayerRigidBody;
    private SpriteRenderer PlayerSpriteRender;

    public void LeftButtonDown() {
        PlayerSpriteRender.flipX = true;
        WalkSpeed = -HorizontalDirection;
    }

    public void RightButtonDown() {
        PlayerSpriteRender.flipX = false;
        WalkSpeed = HorizontalDirection;    
    }

    public void Stop() {
        WalkSpeed = 0f;
    }

    public void OnClickJump() {
        if (IsGrounded)
            PlayerRigidBody.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
    }
    
    void Start()
    {
        PlayerSpriteRender = GetComponent<SpriteRenderer>();
        PlayerRigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {   
        transform.Translate(WalkSpeed, 0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground")
            IsGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground") {
            IsGrounded = false;
        }
    }

}
