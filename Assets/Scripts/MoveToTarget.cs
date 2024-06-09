using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    private PlaceManager placeManager;
    private PlaceIndicator placeIndicator;

    public GameObject target;
    public Animator animator;

    int temp = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        placeManager = FindObjectOfType<PlaceManager>();
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        transform.LookAt(placeIndicator.transform);

        if (placeManager.index == 2)
        {
            temp = 1;
            transform.position = Vector3.MoveTowards(gameObject.transform.position, placeManager.newPlacedObject.transform.position, 0.04f);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Respawn")
        {
            placeManager.index = 1;
            temp = 2;
            Destroy(col.gameObject, 0.1f);
        }
    }

    void Move()
    {
        if (temp == 1)
        {
            animator.SetBool("Run", true);
        }
        else if (temp == 2)
        {
            animator.SetBool("Run", false);
        }
    }
}
