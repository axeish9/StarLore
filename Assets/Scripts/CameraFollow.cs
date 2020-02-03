﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour

{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position= Vector3.Lerp (gameObject.transform.position, new Vector3(0,gameObject.transform.position.y, player.transform.position.z -10), Time.deltaTime *100 );

    }
}
