using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ConstructButtonPointer : MonoBehaviour
{
    public GameObject AllUI, LoadUI;
    public GameObject StoneWall, WoodWall, WoodWallTraingle, StoneWallTraingle, AllBoxesParent, Vault, BackgroudS, StoneWall2X, WoodWall2X;
    public GameObject[] elo;
    public string mapPath;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        foreach (Transform box in AllBoxesParent.transform)
        {

            Destroy(box.gameObject);
            BackgroudS.GetComponent<ContructOnClick>().WoodWallCounter = 0;
            BackgroudS.GetComponent<ContructOnClick>().StoneWallCounter = 0;
            BackgroudS.GetComponent<ContructOnClick>().WoodWallTraingleCounter = 0;
            BackgroudS.GetComponent<ContructOnClick>().StoneWallTraingleCounter = 0;
            BackgroudS.GetComponent<ContructOnClick>().VaultCounter = 0;
            BackgroudS.GetComponent<ContructOnClick>().StoneWallCounter2X = 0;
            BackgroudS.GetComponent<ContructOnClick>().WoodWallCounter2X = 0;
        }
        elo = new GameObject[7];
        elo[0] = Vault;
        elo[1] = WoodWall;
        elo[2] = WoodWallTraingle;
        elo[3] = StoneWall;
        elo[4] = StoneWallTraingle;
        elo[5] = WoodWall2X;
        elo[6] = StoneWall2X;
        AllUI.SetActive(true);
        LoadUI.SetActive(false);
        StreamReader reader;
        string output;
        string path = mapPath;
        reader = new StreamReader(path);
        GameObject CurrentBox;
        while ((output = reader.ReadLine()) != null)
        {
            string[] Dane = output.Split(' ');

            CurrentBox = Instantiate(elo[int.Parse(Dane[0])], new Vector3(float.Parse(Dane[1]), float.Parse(Dane[2]), float.Parse(Dane[3])), Quaternion.Euler(0f, 0f, float.Parse(Dane[4])));
            switch (int.Parse(Dane[0]))
            {
                case 0:
                    BackgroudS.GetComponent<ContructOnClick>().VaultCounter += 1;
                    break;
                case 1:
                    BackgroudS.GetComponent<ContructOnClick>().WoodWallCounter += 1;
                    break;
                case 2:
                    BackgroudS.GetComponent<ContructOnClick>().WoodWallTraingleCounter += 1;
                    break;
                case 3:
                    BackgroudS.GetComponent<ContructOnClick>().StoneWallCounter += 1;
                    break;
                case 4:
                    BackgroudS.GetComponent<ContructOnClick>().StoneWallTraingleCounter += 1;
                    break;
                case 5:
                    BackgroudS.GetComponent<ContructOnClick>().WoodWallCounter2X += 1;
                    break;
                case 6:
                    BackgroudS.GetComponent<ContructOnClick>().StoneWallCounter2X += 1;
                    break;


            }

            //Destroy(CurrentBox.GetComponent<StructureHP>());
            Destroy(CurrentBox.GetComponent<CollisionDetect>());
            Destroy(CurrentBox.GetComponent<StrukturaEKin>());

            //CurrentBox.transform.eulerAngles = new Vector3(0f, 0f, float.Parse(Dane[4]));
            CurrentBox.transform.parent = AllBoxesParent.transform;

        }
    }
}
