using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphScript : MonoBehaviour
{
    /* I think this system is really cool so I saved it but it is an accident
    // note to self, read the instructions before coding
    public GameObject hex;
    public GameObject edgeHex;
    public int IterationsToDo;

    private Hex _self;
    Vector3 newHexPos;
    bool foundPrevious;
    
    public void IterateStart(int iterationsLeft, int direction)
    {
        _self = transform.gameObject.GetComponent<Hex>();
        GameObject toCreate;
        if (iterationsLeft > 2)
        {
            toCreate = hex;
            foundPrevious = false;
            newHexPos = gameObject.transform.GetChild(direction).transform.position;
            for (int i = 0; i < transform.parent.childCount; i++)
            {
                GameObject potentialLink = transform.parent.GetChild(i).gameObject;
                if (potentialLink.transform.position == newHexPos)
                {
                    foundPrevious = true;
                    break;
                }
            }
            if (!foundPrevious)
            {
                int modifier = Random.Range(1, 1);
                GameObject newHex = Instantiate(toCreate, transform.parent);
                newHex.transform.position = newHexPos;
                newHex.gameObject.GetComponent<GraphScript>().IterationsToDo = IterationsToDo - modifier;
                if (_self.Direction + 1 < 6)
                {
                    newHex.gameObject.GetComponent<GraphScript>().IterateStart(IterationsToDo - modifier, _self.Direction + 1);
                }
                else
                {
                    newHex.gameObject.GetComponent<GraphScript>().IterateStart(IterationsToDo - modifier, 0);
                }
                newHex.gameObject.GetComponent<GraphScript>().IterateStart(IterationsToDo - modifier, _self.Direction);
            }
        }
        else if (iterationsLeft > 0)
        {
            toCreate = edgeHex;
            foundPrevious = false;
            newHexPos = gameObject.transform.GetChild(direction).transform.position;
            for (int i = 0; i < transform.parent.childCount; i++)
            {
                GameObject potentialLink = transform.parent.GetChild(i).gameObject;
                if (potentialLink.transform.position == newHexPos)
                {
                    foundPrevious = true;
                    break;
                }
            }
            if (!foundPrevious)
            {
                GameObject newHex = Instantiate(toCreate, transform.parent);
                newHex.transform.position = newHexPos;
            }
        }
    }
    public void Connect()
    {
        for (int a = 0; a < 6; a++)
        {
            newHexPos = gameObject.transform.GetChild(a).transform.position;
            for (int i = 0; i < transform.parent.childCount; i++)
            {
                GameObject potentialLink = transform.parent.GetChild(i).gameObject;
                if (potentialLink.transform.position == newHexPos)
                {
                    _self.connections[a] = potentialLink.gameObject;
                    break;
                }
            } 
        }
    }*/
}
