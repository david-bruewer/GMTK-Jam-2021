using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentMovement : Movement
{

    public GameObject[] weapon; 
    bool canAttack; 

    Vector2 spawnpoint; 

    // Start is called before the first frame update
    void Start()
    {
        canAttack = true; 
        spawnpoint = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y); 
    }
    void Update()
    {
        this.getMovement();
        if(Input.GetKeyDown("t"))
        {
            this.SwitchTimelines();
        }
        if (Input.GetKeyDown("space") && canInteract)
        {
            collision.gameObject.GetComponent<PastInteractable>().OnInteract(this);
        }
        if (Input.GetMouseButtonDown(0) && canAttack)
        {
            switch(direction)
            {
                case Directions.Up:
                    StartCoroutine(attack(weapon[0]));
                    break; 
                case Directions.Right:
                    StartCoroutine(attack(weapon[1]));
                    break; 
                case Directions.Left:
                    StartCoroutine(attack(weapon[2]));
                    break; 
                case Directions.Down:
                   StartCoroutine(attack(weapon[3]));
                    break; 
            }
        }
        
    }

    void FixedUpdate() 
    {
        this.updatePosition();
    }

    private void OnCollisionEnter2D(Collision2D other) {

        Collided(other);
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("dead");
            gameObject.transform.position = spawnpoint; 
        }
    }

    private IEnumerator attack(GameObject weapon)
    {
        canAttack = false; 
        weapon.SetActive(true); 
        yield return new WaitForSeconds(0.5f); 
        weapon.SetActive(false);
        canAttack = true; 

    }

    void respawn(){

    }
}
