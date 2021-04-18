using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text score;
    public static int currentScore;
    public static GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 100;
        score.text = "Puntos: "+currentScore;
        //objects = GameObject.FindGameObjectsWithTag("PickUp");
    }

    // Update is called once per frame
    void Update()
    {

        score.text = "Vida: "+currentScore;
    }
}
