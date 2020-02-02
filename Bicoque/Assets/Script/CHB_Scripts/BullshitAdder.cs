﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullshitAdder : MonoBehaviour
{
    Inventory inventory;
    void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            inventory.AddWood(99);
            inventory.AddStone(99);
            inventory.AddIron(99);
            

            inventory.UpdateCounters();
        }
    }
}
