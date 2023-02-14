using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ContructOnClick : MonoBehaviour
{
    public float EulerAng=0;
    public int wybor = 0, StoneWallCounter, WoodWallCounter, WoodWallTraingleCounter, StoneWallTraingleCounter, VaultCounter, WoodWallCounter2X, StoneWallCounter2X;
    public GameObject StoneWall, WoodWall, WoodWallTraingle, StoneWallTraingle, AllBoxesParent, Vault, WoodWall2X, StoneWall2X;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void WoodWallOnClick()
    {
        wybor = 0;
    }

    public void StoneWallOnClick()
    {
        wybor = 1;
    }
    public void WoodTriangleOnClick()
    {
        wybor = 2;
    }
    public void StoneTriangleOnClick()
    {
        wybor = 3;
    }
    public void VaultOnClick()
    {
        wybor = 4;
    }
    public void WoodWall2XOnClick()
    {
        wybor = 5;
    }
    public void StoneWall2XOnClick()
    {
        wybor = 6;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -5.5)
        {
            switch (wybor)
            {
                case 0:
                    if (WoodWallCounter < 15)
                    {
                        GameObject WoodWall1 = Instantiate(WoodWall, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.Euler(0f,0f,EulerAng));
                        WoodWall1.transform.parent = AllBoxesParent.transform;
                        //Destroy(WoodWall1.GetComponent<StructureHP>());
                        Destroy(WoodWall1.GetComponent<CollisionDetect>());
                        if (gameObject.GetComponent<ConstructFreezeAll>().freeze)
                            WoodWall1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                        WoodWallCounter += 1;
                    }
                    break;
                case 1:
                    if (StoneWallCounter < 10)
                    {
                        GameObject StoneWall1 = Instantiate(StoneWall, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.Euler(0f, 0f, EulerAng));
                        StoneWall1.transform.parent = AllBoxesParent.transform;
                        //Destroy(StoneWall1.GetComponent<StructureHP>());
                        Destroy(StoneWall1.GetComponent<CollisionDetect>());
                        if (gameObject.GetComponent<ConstructFreezeAll>().freeze)
                            StoneWall1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                        StoneWallCounter += 1;
                    }
                    break;
                case 2:
                    if (WoodWallTraingleCounter < 15)
                    {
                        GameObject WoodWallTraingle1 = Instantiate(WoodWallTraingle, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.Euler(0f, 0f, EulerAng));
                        WoodWallTraingle1.transform.parent = AllBoxesParent.transform;
                        //Destroy(WoodWallTraingle1.GetComponent<StructureHP>());
                        Destroy(WoodWallTraingle1.GetComponent<CollisionDetect>());
                        if (gameObject.GetComponent<ConstructFreezeAll>().freeze)
                            WoodWallTraingle1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                        WoodWallTraingleCounter += 1;
                    }
                    break;
                case 3:
                    if (StoneWallTraingleCounter < 10)
                    {
                        GameObject StoneWallTraingle1 = Instantiate(StoneWallTraingle, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.Euler(0f, 0f, EulerAng));
                        StoneWallTraingle1.transform.parent = AllBoxesParent.transform;
                        //Destroy(StoneWallTraingle1.GetComponent<StructureHP>());
                        Destroy(StoneWallTraingle1.GetComponent<CollisionDetect>());
                        if (gameObject.GetComponent<ConstructFreezeAll>().freeze)
                            StoneWallTraingle1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                        StoneWallTraingleCounter += 1;
                    }
                    break;
                case 4:
                    if (VaultCounter < 1)
                    {
                        GameObject Vault1 = Instantiate(Vault, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.Euler(0f, 0f, EulerAng));
                        Vault1.transform.parent = AllBoxesParent.transform;
                        //Destroy(Vault1.GetComponent<StructureHP>());
                        Destroy(Vault1.GetComponent<CollisionDetect>());
                        if (gameObject.GetComponent<ConstructFreezeAll>().freeze)
                            Vault1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                        VaultCounter += 1;
                    }
                    break;
                case 5:
                    if (WoodWallCounter2X < 8)
                    {
                        GameObject WoodWall2X1 = Instantiate(WoodWall2X, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.Euler(0f, 0f, EulerAng));
                        WoodWall2X1.transform.parent = AllBoxesParent.transform;
                        //Destroy(StoneWallTraingle1.GetComponent<StructureHP>());
                        Destroy(WoodWall2X1.GetComponent<CollisionDetect>());
                        if (gameObject.GetComponent<ConstructFreezeAll>().freeze)
                            WoodWall2X1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                        WoodWallCounter2X += 1;
                    }
                    break;
                case 6:
                    if (StoneWallCounter2X < 5)
                    {
                        GameObject StoneWall2X1 = Instantiate(StoneWall2X, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.Euler(0f, 0f, EulerAng));
                        StoneWall2X1.transform.parent = AllBoxesParent.transform;
                        //Destroy(StoneWallTraingle1.GetComponent<StructureHP>());
                        Destroy(StoneWall2X1.GetComponent<CollisionDetect>());
                        if (gameObject.GetComponent<ConstructFreezeAll>().freeze)
                            StoneWall2X1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                        StoneWallCounter2X += 1;
                    }
                    break;
            }
        }
    }
}
