using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class ConstructNewLoad : MonoBehaviour
{
    int mapPointer;
    int fileCount;
    public GameObject AllUI, LoadUI, NButton, PButton, Map1Button, Map2Button, Map3Button, Map4Button, Map5Button, Map6Button, Map7Button, Map8Button;
    GameObject[] MapPreviewButtons;
    string[] PNGfileArray;
    // Start is called before the first frame update
    Texture2D tex2d;
    byte[] PNGfileData;
    string buttonname;
    string[] mapPathArray;


    public void OnNextClicked()
    {

            
            MapPreviewLoad();
            PButton.SetActive(true);

    }
    public void OnPrevClicked()
    {

        if ((fileCount - mapPointer)==0)
        {
            mapPointer -= (8+(fileCount%8));
        }else mapPointer -= 16;
        NButton.SetActive(true);
        MapPreviewLoad();
        

    }
    public void OnLoadClicked()
    {
        gameObject.GetComponent<ContructOnClick>().wybor = 98;
        AllUI.SetActive(false);
        LoadUI.SetActive(true);
        MapPreviewButtons = new GameObject[8];
        MapPreviewButtons[0] = Map1Button;
        MapPreviewButtons[1] = Map2Button;
        MapPreviewButtons[2] = Map3Button;
        MapPreviewButtons[3] = Map4Button;
        MapPreviewButtons[4] = Map5Button;
        MapPreviewButtons[5] = Map6Button;
        MapPreviewButtons[6] = Map7Button;
        MapPreviewButtons[7] = Map8Button;
        mapPathArray = Directory.GetFiles(UnityEngine.Application.persistentDataPath + "\\UserMaps", "*.txt", SearchOption.TopDirectoryOnly);
        fileCount = Directory.GetFiles(UnityEngine.Application.persistentDataPath + "\\UserMaps", "*.txt", SearchOption.TopDirectoryOnly).Length;
        PNGfileArray = Directory.GetFiles(UnityEngine.Application.persistentDataPath + "\\UserMaps", "*.png", SearchOption.TopDirectoryOnly);
        Debug.Log("Files:" + fileCount);
        if (fileCount > 0)
        {
            mapPointer = 0;
            MapPreviewLoad();            
        }

    }
    void MapPreviewLoad()
    {
        
        for (int i = 0; i < 8; i++)
        {
            buttonname = "Map " + (i + 1);
            Debug.Log("Map Pointer bef. button load:" + mapPointer);
            if (mapPointer<fileCount)
            {

                tex2d = new Texture2D(2, 2);
                
                //Debug.Log(PNGfileArray[mapPointer].Length);
                PNGfileData = System.IO.File.ReadAllBytes(PNGfileArray[mapPointer]);
                tex2d.LoadImage(PNGfileData);
                //tex2d.LoadRawTextureData(reader.Read)
                MapPreviewButtons[i].SetActive(true);
                MapPreviewButtons[i].GetComponent<ConstructButtonPointer>().mapPath = mapPathArray[mapPointer];
                MapPreviewButtons[i].GetComponent<Image>().sprite = Sprite.Create(tex2d, new Rect(0.0f, 0.0f, tex2d.width, tex2d.height), new Vector2(0.5f, 0.5f));
                MapPreviewButtons[i].GetComponentInChildren<TMP_Text>().text = Path.GetFileNameWithoutExtension(PNGfileArray[mapPointer]);
                mapPointer += 1;
                Debug.Log("Map Pointer after button load:" + mapPointer);
                
            }
            else
            {
                MapPreviewButtons[i].SetActive(false);
                Debug.Log("Generating empty slot...");
                //GameObject.Find(buttonname).GetComponent<Image>().sprite = null;
                //GameObject.Find(buttonname).GetComponentInChildren<TMP_Text>().text = "Empty map slot";
            }
        }
        if (mapPointer >= fileCount)
        {

            NButton.SetActive(false);
        }
        else NButton.SetActive(true);

        if (mapPointer - 8 <= 0)
        {

            PButton.SetActive(false);
        }
        else PButton.SetActive(true);

    }
}
     /*   asyncOperation = SceneManager.LoadSceneAsync("ConstructLoad", LoadSceneMode.Additive);
        
        StartCoroutine(WaitForPreviewLoad(asyncOperation));

        Debug.Log("Load Progress :" + asyncOperation.isDone);
        //rt = new RenderTexture(256, 256, 8);
        
        //Debug.Log("Load Progress :" + asyncOperation.isDone);


        //Camera.main.Render();
        //ri.texture = rt;
    }

    IEnumerator WaitForPreviewLoad(UnityEngine.AsyncOperation asyncOperation1)
    {
        while(!asyncOperation1.isDone)
            yield return null;
        if(asyncOperation1.isDone)
            Debug.Log("Load Progress1 :" + asyncOperation1.isDone);
        asyncOperation.allowSceneActivation = true;
        RenderTexture.active = rt;
        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + "\\UserMaps\\" + "SomeLevel.png");
        var tex = new Texture2D(rt.width, rt.height);       
        tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        tex.Apply();
        var path = Application.persistentDataPath + "\\UserMaps\\" + "elo.png";
        File.WriteAllBytes(path, tex.EncodeToPNG());
        //asyncOperation = SceneManager.UnloadSceneAsync(4, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);

    }
     */

