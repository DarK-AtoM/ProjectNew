using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public Animator anim;
    int speed = 5;
    int jumpForce = 300;
    bool onGround;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) 
        {
            anim.SetBool("run", true);
            anim.SetBool("idle", false);
            transform.Translate(Vector2 .left *Time.deltaTime*speed) ;

        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run", true);
            anim.SetBool("idle", false);
            transform.Translate(Vector2 . right * Time.deltaTime*speed);

        }
        if (Input.GetKeyDown(KeyCode.W)) ;
        {
            anim.SetTrigger("jump");
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
            
            
            
       
        }
        if(Input.anyKey==false) 
        {
            anim.SetBool("run", false);
            anim.SetBool("idle", true);
        }
    }
}

