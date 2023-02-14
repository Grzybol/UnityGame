using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void RotateOnClick()
    {
        GameObject.Find("Script").GetComponent<ContructOnClick>().EulerAng += 90;
    }
}
