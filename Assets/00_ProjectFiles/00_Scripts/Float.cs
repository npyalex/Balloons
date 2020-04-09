using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float timeToFull, maxFloat;
    private float speedMultiplier, timer;
    private Vector3 startPos, currPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        speedMultiplier = timer;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speedMultiplier * Time.deltaTime;
        timer += Time.deltaTime;
        speedMultiplier = timer;
        if (timer >= timeToFull)
        {
            timer = maxFloat;
        }
        //currPos = transform.position;
        //if (currPos.y < startPos.y)
        //{
        //    transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);
        //}
    }
}
