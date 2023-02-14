using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleButtons : MonoBehaviour
{
    public static int test;
    public GameObject LoadUI;
    // Start is called before the first frame update
    void Start()
    {
        //StoryUI.SetActive(true);
    }

    public void OnBattleLvl1Clicked()
    {
        LevelLoad.level = 0;
        
        SceneManager.LoadScene(1);
        
    }
    public void OnBattleLvl2Clicked()
    {
        LevelLoad.level = 1;
        SceneManager.LoadScene(1);

    }
}
