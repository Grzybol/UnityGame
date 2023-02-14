using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;


public class ConstructSaveB : MonoBehaviour
{
    public GameObject SaveUI, AllTheBoxes, AllUI;
    // Start is called before the first frame update
    //public GameObject SaveUI;
    void Start()
    {
        
    }
    public void OnSaveClick()
    {
        AllUI.SetActive(false);
        SaveUI.SetActive(true);
        /*
        foreach (Transform x in AllTheBoxes.transform)
        {
            x.gameObject.GetComponent<DragAndDrop>().enabled = false;
            //x.transform.SetAsLastSibling();
        }
        */
        GameObject.Find("Script").GetComponent<ContructOnClick>().wybor = 98;       
        GameObject.Find("Script").GetComponent<ConstructFreezeAll>().freeze = false;
        GameObject.Find("Script").GetComponent<ConstructFreezeAll>().FreezeOnClick();
    }
    public void OnCancelSaveClick()
    {
        SaveUI.SetActive(false);
        AllUI.SetActive(true);
        GameObject.Find("Script").GetComponent<ConstructFreezeAll>().FreezeOnClick();
        /*
        foreach (GameObject x in GameObject.FindGameObjectsWithTag("Structure"))
            x.GetComponent<DragAndDrop>().enabled = true ;
        */
    }
}
