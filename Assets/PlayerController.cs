using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float x;
    float z;
    public float moveSpeed = 2;

    Rigidbody rb;
    //アニメーターを設定
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //アニメーターを取得
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(x, 0, z) * moveSpeed;
        //パラメータを取得
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }
}
