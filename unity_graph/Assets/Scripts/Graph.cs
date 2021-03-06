﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab = default;

    void Awake()
    {
        Transform point = Instantiate(pointPrefab);
        point.localPosition = Vector3.right;

        point = Instantiate(pointPrefab);
		point.localPosition = Vector3.right * 2f;
    }
}
