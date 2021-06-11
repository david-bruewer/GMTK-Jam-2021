using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentInteractable : MonoBehaviour
{


    //Set Variables (enum?) and do different things accordingly 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract()
    {
      Destroy(gameObject); 
    }
}
