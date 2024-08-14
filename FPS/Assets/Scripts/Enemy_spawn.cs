using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;


public class Enemy_spawn : MonoBehaviour
{
    public GameObject spawn;
    public GameObject Enemy;
    public float length = 5000;
    float random;
    // Start is called before the first frame update
    void Start()
    {
       //Instantiate(Enemy, spawn1.transform.position, Quaternion.identity);
        random = Random.Range(4f, 9f);
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator SpawnCoroutine()
    {
        for (int i = 0; i < length; i++)
        {
            yield return new WaitForSeconds(random);
            Instantiate(Enemy, spawn.transform.position, Quaternion.identity);
        }
    }

}

