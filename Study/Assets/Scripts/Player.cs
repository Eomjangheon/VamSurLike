
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Vector2 inputVec;
    [SerializeField]
    float speed;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator animator;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        speed = 3;
    }

    
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

	private void FixedUpdate()
	{
        Vector2 nextVec=inputVec.normalized * speed* Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        
	}

	void LateUpdate()
	{
		animator.SetFloat("Speed", inputVec.magnitude);

		if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
	}
}
