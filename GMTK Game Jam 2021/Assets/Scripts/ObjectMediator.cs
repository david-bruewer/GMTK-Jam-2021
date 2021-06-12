using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMediator : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject pastPlayer; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract(GameObject presentObject)
    {
       ObjectTypes type = presentObject.GetComponent<Interactable>().type;
        switch(type)
        {
            case ObjectTypes.Destroyable:
                Destroy(presentObject);
                break; 
            case ObjectTypes.Moveable: 
                switch(pastPlayer.GetComponent<Movement>().direction)
                {
                    case Directions.Left:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x -1f, presentObject.transform.position.y);
                    break;
                     case Directions.Right:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x + 1f, presentObject.transform.position.y);
                    break;
                     case Directions.Up:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x , presentObject.transform.position.y+1f);
                    break;
                     case Directions.Down:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x, presentObject.transform.position.y-1f);
                    break;
                }
                
                break; 
            case ObjectTypes.Dropper:
                switch(pastPlayer.GetComponent<Movement>().direction)
                {
                    case Directions.Left:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x -1f, presentObject.transform.position.y);
                    break;
                     case Directions.Right:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x + 1f, presentObject.transform.position.y);
                    break;
                     case Directions.Up:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x , presentObject.transform.position.y+1f);
                    break;
                     case Directions.Down:
                    presentObject.transform.position =  new Vector2(presentObject.transform.position.x, presentObject.transform.position.y-1f);
                    break;
                }

                presentObject.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                break;

        }
        
    }
}
