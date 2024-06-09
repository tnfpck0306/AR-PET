using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    private PlaceIndicator placeIndicator;
    public GameObject FoxToPlace;
    public GameObject objectToPlace;

    public int index = 0;

    private GameObject newFox;
    public GameObject newPlacedObject;


    // Start is called before the first frame update
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }

    // Update is called once per frame
    public void ClickToPlace()
    {
        if(index == 0)
        {
            newFox = Instantiate(FoxToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
            index = 1;
        }
        else
        {
            newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
            index = 2;
        }
    }
}
