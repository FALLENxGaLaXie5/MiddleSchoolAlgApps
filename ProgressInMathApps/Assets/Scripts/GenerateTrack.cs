using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTrack : MonoBehaviour
{
    // Use this for initialization

    public int numberOfTracks;
    //int currentTrackGeneration = 1;

    public GameObject trackPrefab;
    public GameObject startTrack;


    GameObject currentTrack;
    GameObject currentTrackStart;
    GameObject currentTrackEnd;
	void Start ()
    {
        currentTrack = startTrack.gameObject;
        currentTrackStart = currentTrack.transform.Find("EndPoint").gameObject;
        currentTrackEnd = currentTrack.transform.Find("StartPoint").gameObject;
        generateTrack();
	}

    void generateTrack()
    {
        for(int i = 1; i < numberOfTracks; i++)
        {
            currentTrack = Instantiate(trackPrefab, currentTrackEnd.transform.position, Quaternion.identity);
            currentTrackStart = currentTrack.transform.Find("EndPoint").gameObject;
            currentTrackEnd = currentTrack.transform.Find("StartPoint").gameObject;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
