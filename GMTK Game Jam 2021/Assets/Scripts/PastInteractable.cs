using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastInteractable : Interactable
{

    public GameObject presentObject;

    public GameObject Mediator; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract(){
        Debug.Log("Interacted");

        if(presentObject) //just IN CASE we make that present player can interact =p
            Mediator.GetComponent<ObjectMediator>().OnInteract(presentObject);
        Mediator.GetComponent<ObjectMediator>().OnInteract(gameObject);
    }
    
}
