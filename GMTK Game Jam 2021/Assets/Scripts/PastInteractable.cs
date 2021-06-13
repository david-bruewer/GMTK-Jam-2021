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

    public void OnInteract(Movement player){

        Mediator.GetComponent<ObjectMediator>().OnInteract(gameObject, player, false, null);
        if (presentObject) //just IN CASE we make that present player can interact =p
            Mediator.GetComponent<ObjectMediator>().OnInteract(presentObject,player, true, gameObject);
    }
    
}
