using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftTable : MonoBehaviour
{
    [SerializeField]
    private GameObject invCarrier;
    private Inventory inventory;

    [System.Serializable]
    public class Wolftrap_cost
    {
        public int wood_need;
        public int iron_need;
    }

    [System.Serializable]
    public class Barricade_cost
    {
        public int stone_need;
        public int iron_need;
    }

    [System.Serializable]
    public class Sandbag_cost
    {
        public int stone_need;
        public int wood_need;
    }

    public Wolftrap_cost wolfCost = new Wolftrap_cost();
    public Barricade_cost barrCost = new Barricade_cost();
    public Sandbag_cost sandCost = new Sandbag_cost();
    void Start()
    {
        inventory = invCarrier.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // To be called OnClick
    public void CraftWolftrap()
    {
        if (inventory.mt_wood > wolfCost.wood_need && inventory.mt_iron > wolfCost.iron_need)
        {
            inventory.UseWood(wolfCost.wood_need);
            inventory.UseIron(wolfCost.iron_need);

            inventory.AddWolfTrap(1);

            inventory.UpdateCounters();
        }
    }

    public void CraftBarricade()
    {
        if (inventory.mt_stone > barrCost.stone_need && inventory.mt_iron > barrCost.iron_need)
        {
            inventory.UseStone(barrCost.stone_need);
            inventory.UseIron(barrCost.iron_need);

            inventory.AddBarricade(1);

            inventory.UpdateCounters();
        }
    }

    public void CraftSandbag()
    {
        if (inventory.mt_stone > sandCost.stone_need && inventory.mt_wood > sandCost.wood_need)
        {
            inventory.UseStone(sandCost.stone_need);
            inventory.UseWood(sandCost.wood_need);

            inventory.AddSandbag(1);

            inventory.UpdateCounters();
        }
    }
}
