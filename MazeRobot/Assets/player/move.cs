using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{   
    
    protected Joystick joy;
    // Start is called before the first frame update
    void Start()
    {
        joy = FindObjectOfType<Joystick>();
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        Vector2 move = new Vector2(joy.Horizontal * 4, joy.Vertical * 4);
        RaycastHit2D raycast =  Physics2D.Raycast(transform.position, move,distance:2.5f);
        rigidbody.velocity = move;
        if (raycast.collider == null)
        {
            

       }

        
        
    }
}
