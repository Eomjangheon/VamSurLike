
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
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
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
}
