using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private float WalkSpeed;
    [SerializeField]
    private bool IsGrounded;
    [SerializeField]
    private bool IsAbleToClimb;

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
        if (IsAbleToClimb) {
            PlayerRigidBody.velocity = Vector2.zero;
            PlayerRigidBody.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            IsGrounded = false;
            PlayerAnimator.SetBool("IsGrounded", IsGrounded);
        }
        else if (IsGrounded) {
            PlayerRigidBody.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            IsGrounded = false;
            PlayerAnimator.SetBool("IsGrounded", IsGrounded);
            }   
    }
    
    void Start()
    {
        PlayerSpriteRender = GetComponent<SpriteRenderer>();
        PlayerRigidBody = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {   
        if (IsAbleToClimb)
            PlayerRigidBody.gravityScale = 0;
        else
            PlayerRigidBody.gravityScale = 2.5f;
        
        PlayerAnimator.SetFloat("MoveX", Mathf.Abs(WalkSpeed));
        PlayerRigidBody.velocity = new Vector2(1 * WalkSpeed, PlayerRigidBody.velocity.y);
    }

    private void OnTriggerStay2D(Collider2D other) {
       if (other.gameObject.tag == "ClimbableObject") {
           IsAbleToClimb = true;
           PlayerAnimator.SetBool("IsAbleToClimb", true);
       }
    }

    private void OnTriggerExit2D(Collider2D other) {
       if (other.gameObject.tag == "ClimbableObject") {
           IsAbleToClimb = false;
           PlayerAnimator.SetBool("IsAbleToClimb", false);
       }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground")
            IsGrounded = true;
            PlayerAnimator.SetBool("IsGrounded", IsGrounded);
    }
}
