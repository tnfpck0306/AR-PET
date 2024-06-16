using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBall : MonoBehaviour
{
    float rx = 0;
    float ry = 0;
    public GameObject Ball; // 공의 Prefab
    private GameObject newBall; // 생성되는 공
    private Vector3 ballPosition;
    public Vector3 throwPower;

    void Start()
    {
        ballPosition = new Vector3(0, -0.3f, 0.7f);

        rx = transform.eulerAngles.x;
        ry = transform.eulerAngles.y;

        Ball.transform.position = transform.position + ballPosition;


        newBall = Instantiate(Ball, Ball.transform.position, Ball.transform.rotation);
        newBall.transform.SetParent(transform);

        newBall.GetComponent<Rigidbody>().useGravity = false;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            newBall.transform.parent = null;
            newBall.GetComponent<Rigidbody>().useGravity = true;
            newBall.GetComponent<Rigidbody>().AddForce(throwPower, ForceMode.Impulse);
        }
        
    }
}
