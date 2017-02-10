using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float positionalValue = 0;
    public void Slider_Changed(float newValue)
    {
        positionalValue = newValue;
    }

    public void moveTrain()
    {
        //move train to the positional value of that track
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
