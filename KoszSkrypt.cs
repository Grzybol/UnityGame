using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoszSkrypt : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        switch (other.gameObject.GetComponent<StructureHP>().StructureID)
        {
            case 0:
                GameObject.Find("Script").GetComponent<ContructOnClick>().VaultCounter -= 1;
                break;
            case 1:
                GameObject.Find("Script").GetComponent<ContructOnClick>().WoodWallCounter -= 1;
                break;
            case 2:
                GameObject.Find("Script").GetComponent<ContructOnClick>().WoodWallTraingleCounter -= 1;
                break;
            case 3:
                GameObject.Find("Script").GetComponent<ContructOnClick>().StoneWallCounter -= 1;
                break;
            case 4:
                GameObject.Find("Script").GetComponent<ContructOnClick>().StoneWallTraingleCounter -= 1;
                break;
            case 5:
                GameObject.Find("Script").GetComponent<ContructOnClick>().WoodWallCounter2X -= 1;
                break;
            case 6:
                GameObject.Find("Script").GetComponent<ContructOnClick>().StoneWallCounter2X -= 1;
                break;

        }
    }
}
