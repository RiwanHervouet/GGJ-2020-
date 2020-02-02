using System.Collections;
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
            inventory.AddIron(2);
            inventory.AddWolfTrap(3);
            inventory.AddSandbag(2);

            inventory.UpdateCounters();
        }
    }
}
