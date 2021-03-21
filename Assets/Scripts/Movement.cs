using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.5f;
    public Rigidbody2D player;
    Vector2 move;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        player.MovePosition(player.position + move * speed * Time.fixedDeltaTime);
    }
}
