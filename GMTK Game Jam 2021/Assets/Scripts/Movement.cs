using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Movement Speed
    [SerializeField]
    float moveSpeed = 5f;

    //Character rigidBody object
    [SerializeField]
    Rigidbody2D rb;

    //Movement vector
    Vector2 movement;

    public Directions direction; 

    public GameObject Mediator; 

    //Animator 
    //[SerializeField]
   // Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }
  void Update() {
      getMovement();
        if(Input.GetKeyDown("t"))
        {
            this.SwitchTimelines();
        }
   //Updates Movement Vector 

            //Updates animator prevHorizontal for idle 
            //if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
           // {
           //     animator.SetFloat("PrevHorizontal", movement.x);
           //     animator.SetFloat("PrevVertical", movement.y);
           // }



            //Updates Animator
            //animator.SetFloat("Horizontal", movement.x);
           // animator.SetFloat("Vertical", movement.y);
            //animator.SetFloat("Speed", movement.sqrMagnitude);
        
    }

    void FixedUpdate()
    {
        updatePosition();
    }

    public void getMovement()
    {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            if(movement.x == 1)
            {
                direction = Directions.Right; 
            } 
            if(movement.x == -1)
            {
                direction = Directions.Left;
            }
            if (movement.y == 1)
            {
                direction = Directions.Up;
            }
            if (movement.y == -1)
            {
                direction = Directions.Down;
            }

    }

    public void updatePosition()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void SwitchTimelines()
    {
        Mediator.GetComponent<TimelineManager>().SwitchTimelines();
    }
}

