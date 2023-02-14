using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMenuClicked()
    {
        SceneManager.LoadScene(0);
    }
}
