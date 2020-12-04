using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    float WalkSpeed;
    bool IsGrounded;
    public float HorizontalDirection = 5f;
    public float JumpForce = 10f;
    public Animator PlayerAnimator;
    
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
            IsGrounded = false;
            PlayerAnimator.SetBool("IsGrounded", IsGrounded);    
    }
    
    void Start()
    {
        PlayerSpriteRender = GetComponent<SpriteRenderer>();
        PlayerRigidBody = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {   
        //transform.Translate(WalkSpeed, 0f, 0f);
        PlayerAnimator.SetFloat("MoveX", Mathf.Abs(WalkSpeed));
        PlayerRigidBody.velocity = new Vector2(1 * WalkSpeed, PlayerRigidBody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground")
            IsGrounded = true;
            PlayerAnimator.SetBool("IsGrounded", IsGrounded);
    }
/*
    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground") {
            IsGrounded = false;
            PlayerAnimator.SetBool("IsGrounded", IsGrounded);
        }
    }
*/
}
