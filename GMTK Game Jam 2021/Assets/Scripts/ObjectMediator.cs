using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMediator : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject pastPlayer; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract(GameObject presentObject, Movement pastPlayer, bool isPast, GameObject past)
    {
        Interactable i = presentObject.GetComponent<Interactable>();
        ObjectTypes type = i.type;
        switch(type)
        {
            case ObjectTypes.Destroyable:
                if(past)
                    Destroy(presentObject);
                else
                    i.DestroyMe(); 
                break; 
            case ObjectTypes.Moveable:
                if (isPast)
                {
                    presentObject.transform.position = past.transform.position;
                    break;
                }
                switch (pastPlayer.GetComponent<Movement>().direction)
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
                if (isPast)
                {
                    presentObject.transform.position = past.transform.position;
                    break;
                }
                switch (pastPlayer.GetComponent<Movement>().direction)
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

                if (Vector2.Distance(presentObject.GetComponent<Interactable>().goal.transform.position, presentObject.transform.position) < 0.5f)
                {
                
                 presentObject.GetComponent<BoxCollider2D>().enabled = false;
                 i.goal.GetComponent<BoxCollider2D>().enabled = false;
                 
                }
                break;

            case ObjectTypes.HoleCover:
                if (isPast)
                {
                    presentObject.transform.position = past.transform.position;
                    i.Enable();
                    if (i.goal)
                    {
                        presentObject.GetComponent<BoxCollider2D>().enabled = false;
                        i.goal.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    break;
                }
                switch (pastPlayer.GetComponent<Movement>().direction)
                {
                    case Directions.Left:
                        presentObject.transform.position = new Vector2(presentObject.transform.position.x - 1f, presentObject.transform.position.y);
                        break;
                    case Directions.Right:
                        presentObject.transform.position = new Vector2(presentObject.transform.position.x + 1f, presentObject.transform.position.y);
                        break;
                    case Directions.Up:
                        presentObject.transform.position = new Vector2(presentObject.transform.position.x, presentObject.transform.position.y + 1f);
                        break;
                    case Directions.Down:
                        presentObject.transform.position = new Vector2(presentObject.transform.position.x, presentObject.transform.position.y - 1f);
                        break;
                }
                i.Enable();
                if (i.goal)
                {
                    Debug.Log("is this useful?");
                    presentObject.GetComponent<BoxCollider2D>().enabled = false;
                    i.goal.GetComponent<BoxCollider2D>().enabled = false;
                }
                break;

        }
        
    }
}
