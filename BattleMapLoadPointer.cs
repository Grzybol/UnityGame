using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleMapLoadPointer : MonoBehaviour
{
    public GameObject LoadUI;
    public string mapPath;
    void Start()
    {
       gameObject.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        PlayerPrefs.SetString("MapLoadPath", mapPath);
        SceneManager.LoadScene(1);
    }
}
