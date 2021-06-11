using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastMovement : Movement
{
    // Start is called before the first frame update
    Collision2D collision; 

    bool canInteract; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.getMovement();
        if(Input.GetKeyDown("t"))
        {
            this.SwitchTimelines();
        }

        if(Input.GetKeyDown("space") && canInteract)
        {
             // Debug.Log("Interacted");
            collision.gameObject.GetComponent<PastInteractable>().OnInteract();
        }
        
    }

    void FixedUpdate() 
    {
        this.updatePosition();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Interactable")
        {
            collision = col; 
            canInteract = true; 
        }
    }

    private void OnCollisionExit2D(Collision2D col) 
    {
        collision = null; 
        canInteract = false; 
        
    }
}
