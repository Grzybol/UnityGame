using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using TMPro;
using System.Linq;
using System.ComponentModel;

public class ConstructExport : MonoBehaviour
{
    public GameObject AllTheBoxes, SaveUI, AllUI;
    public TMP_InputField UserMapInput;
    // Start is called before the first frame update
    public void ExportOnClick()
    {
        SaveUI.SetActive(false);
        AllUI.SetActive(false);
        if (!Directory.Exists(Application.persistentDataPath + "\\UserMaps"))
            Directory.CreateDirectory(Application.persistentDataPath + "\\UserMaps");
        StartCoroutine(WaitForPreviewLoad());     
    }
   
    IEnumerator WaitForPreviewLoad()
    {
        ScreenCapture.CaptureScreenshot(Application.persistentDataPath + "\\UserMaps\\" + UserMapInput.text + ".png");
        yield return new WaitForSeconds(0.5f);
        AfterScreenShot();
    }
    void AfterScreenShot()
    {
        string Struktury = "";

        foreach (Transform box in AllTheBoxes.transform)
        {
            Struktury = Struktury + box.GetComponent<StructureHP>().StructureID.ToString() + " " + box.GetComponent<Transform>().position.x.ToString() + " " + box.GetComponent<Transform>().position.y.ToString() + " " +
                box.GetComponent<Transform>().position.z.ToString() + " " + box.GetComponent<Transform>().rotation.eulerAngles.z + "\n";
        }
        if (UserMapInput.text.Count() > 3)
        {
            string path = Application.persistentDataPath + "\\UserMaps\\" + UserMapInput.text + ".txt";
            File.Delete(path);
            StreamWriter writer = new StreamWriter(path, true);
            writer.Write(Struktury);
            writer.Close();
            AllUI.SetActive(true);
        }
        else SaveUI.SetActive(true);

    }
}
