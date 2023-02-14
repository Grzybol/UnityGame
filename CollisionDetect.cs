using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    
        private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (gameObject.tag == "Structure" && collision.gameObject.tag == "Player")
            gameObject.GetComponent<StructureHP>().HP -= collision.gameObject.GetComponent<PociskEnergiaKinetyczna>().EnergiaKinetyczna;
        if (gameObject.tag == "Structure" && collision.gameObject.tag == "Structure")
        {
            gameObject.GetComponent<StructureHP>().HP -= collision.gameObject.GetComponent<StrukturaEKin>().EnergiaKinetyczna;
            gameObject.GetComponent<StructureHP>().HP -= gameObject.GetComponent<StrukturaEKin>().EnergiaKinetyczna;
        }
        if (gameObject.tag == "Structure" && collision.gameObject.tag == "Border")
            gameObject.GetComponent<StructureHP>().HP -= gameObject.GetComponent<StrukturaEKin>().EnergiaKinetyczna;






        /*
        Rigidbody2D component;
        if (collision.gameObject.TryGetComponent<Rigidbody2D>(out component) != false)
        {
            

            if (gameObject.tag == "Player" && collision.gameObject.tag == "Structure")
            {

                collision.gameObject.GetComponent<StructureHP>().HP -= gameObject.GetComponent<PociskEnergiaKinetyczna>().EnergiaKinetyczna;
                

            }
            
            if (gameObject == struktura && collision.gameObject == struktura)
            {
                gameObject.GetComponent<StructureHP>().HP -= collision.gameObject.GetComponent<StrukturaEKin>().EnergiaKinetyczna;
                gameObject.GetComponent<StructureHP>().HP -= gameObject.GetComponent<StrukturaEKin>().EnergiaKinetyczna;
                

            }
            
            if (gameObject.tag == "Structure" && collision.gameObject.tag == "Structure")
            {
                gameObject.GetComponent<StructureHP>().HP -= collision.gameObject.GetComponent<StrukturaEKin>().EnergiaKinetyczna;
                gameObject.GetComponent<StructureHP>().HP -= gameObject.GetComponent<StrukturaEKin>().EnergiaKinetyczna;
                
            }
        */
        



    }
}