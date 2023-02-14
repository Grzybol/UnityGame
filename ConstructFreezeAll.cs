using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructFreezeAll : MonoBehaviour
{
    public GameObject AllTheBoxes;
    public bool freeze;

    public void FreezeOnClick()
    {

        if (freeze)
        {
            foreach (Transform box in AllTheBoxes.transform)
            {
                box.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            }

        }
        else
        {
            foreach (Transform box in AllTheBoxes.transform)
            {
                box.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
        freeze = !freeze;
    }
}

