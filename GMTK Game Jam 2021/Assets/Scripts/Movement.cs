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

    public bool canInteract;
    public Collision2D collision;

    //Animator 
    //[SerializeField]

    public Animator animator;


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
        if (Input.GetKeyDown("space") && canInteract)
        {
            collision.gameObject.GetComponent<PastInteractable>().OnInteract(this);
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

            Vector3 characterScale = transform.localScale;

            if(movement.x == 1)
            {
                direction = Directions.Right; 
                characterScale.x = 1;
            } 
            if(movement.x == -1)
            {
                direction = Directions.Left;
                characterScale.x = -1;
            }
            if (movement.y == 1)
            {
                direction = Directions.Up;
            }
            if (movement.y == -1)
            {
                direction = Directions.Down;
            }

            animator.SetFloat("Moving", movement.sqrMagnitude);

            transform.localScale = characterScale;

    }

    public void updatePosition()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void SwitchTimelines()
    {
        Mediator.GetComponent<TimelineManager>().SwitchTimelines();
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        Collided(col);
    }

    public void Collided(Collision2D col)
    {
        
        if (col.gameObject.tag == "Interactable")
        {
            collision = col;
            canInteract = true;

        }
        if (col.gameObject.tag == "Sword")
        {
            collision = col; 
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        collision = null;
        canInteract = false;

    }
}

