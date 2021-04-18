using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Piedra"){
            UIManager.currentScore -= 1;
            
        }else {
            if(collision.gameObject.tag == "Pez"){
                UIManager.currentScore -= 5;
            }
        }
    }
}
