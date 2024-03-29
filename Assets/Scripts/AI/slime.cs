using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] protected Animator animator;
    public Collider2D myCollider;

    private float timer = 0;
    private Rigidbody2D rb;
    private bool isDead = false;

    private float keyTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>();
        animator.SetBool("IsDie", false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.J)){
            keyTimer = Time.time;
            myCollider.isTrigger = true;
        }

        if(Time.time - keyTimer > 0.7){
            keyTimer = 0;
            myCollider.isTrigger = false;
        }

        if(Time.time - timer > 1 && isDead) 
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(keyTimer != 0){
            //Debug.Log("trigger is working(shell)");
            isDead = true;
            animator.SetBool("IsDie", true);
            timer = Time.time;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(keyTimer != 0){
            //Debug.Log("trigger is working(shell)");
            isDead = true;
            animator.SetBool("IsDie", true);
            timer = Time.time;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Black" || collision.gameObject.tag == "Rock" || collision.gameObject.tag == "Tornado")
        {
            isDead = true;
            animator.SetBool("IsDie", true);
            timer = Time.time;
        }
    }
}
