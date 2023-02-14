using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelLoad : MonoBehaviour
{
    public static int level;
    public GameObject StoneWall, WoodWall, WoodWallTraingle, StoneWallTraingle, AllBoxesParent, Vault, StoneWall2X, WoodWall2X;
    public GameObject[] elo;
    // Start is called before the first frame update
    void Start()
    {
        elo = new GameObject[7];
        elo[0] = Vault;
        elo[1] = WoodWall;
        elo[2] = WoodWallTraingle;
        elo[3] = StoneWall;
        elo[4] = StoneWallTraingle;
        elo[5] = WoodWall2X;
        elo[6] = StoneWall2X;
        string path;
        StreamReader reader;
        string output;
        path = PlayerPrefs.GetString("MapLoadPath");
        reader = new StreamReader(path);
        GameObject CurrentBox;
        while ((output = reader.ReadLine()) != null)
        {
            string[] Dane = output.Split(' ');
            //Debug.Log(float.Parse(Dane[4]));
            CurrentBox = Instantiate(elo[int.Parse(Dane[0])], new Vector3(float.Parse(Dane[1]), float.Parse(Dane[2]), float.Parse(Dane[3])), Quaternion.Euler(0f, 0f, float.Parse(Dane[4])));
            //CurrentBox.transform.eulerAngles = new Vector3(0f, 0f, float.Parse(Dane[4]));
            CurrentBox.transform.parent = AllBoxesParent.transform;
            CurrentBox.GetComponent<DragAndDrop>().enabled = false;
        }

    }
}


