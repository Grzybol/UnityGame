using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OnFire : MonoBehaviour
{
    public Button FireButton;
    public Slider PowerSlider, AngleSlider;
    public GameObject PociskLvl1, PociskLvl2;
    public int PociskLvl;
    
    void Start()
    {
        
        FireButton.onClick.AddListener(TaskOnClickFire);
        
    }
    void TaskOnClickFire()
    {
        
        switch (PociskLvl)
        {
            case 0:

                GameObject Plvl1 = Instantiate(PociskLvl1, new Vector2(-7.88f, -3.57f), Quaternion.identity);
                Plvl1.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((PowerSlider.gameObject.GetComponent<Slider>().value) * 1, (PowerSlider.gameObject.GetComponent<Slider>().value) * (AngleSlider.gameObject.GetComponent<Slider>().value));
                Plvl1.gameObject.GetComponent<ProjectileTimer>().PTimer = 5;
                break;
            case 1:

                GameObject Plvl2 = Instantiate(PociskLvl2, new Vector2(-7.88f, -3.57f), Quaternion.identity);
                Plvl2.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((PowerSlider.gameObject.GetComponent<Slider>().value) * 1, (PowerSlider.gameObject.GetComponent<Slider>().value) * (AngleSlider.gameObject.GetComponent<Slider>().value));
                Plvl2.gameObject.GetComponent<ProjectileTimer>().PTimer = 5;
                break;

        }
    } 
}
