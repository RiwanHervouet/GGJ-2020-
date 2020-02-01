using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Materials
    private int mt_wood;
    private int mt_stone;
    private int mt_iron;

    //Parts
    private int pt_planks;
    private int pt_rivets;
    private int pt_bricks;
    private int pt_pebbles;

    //Traps
    private int tr_wolftrap;
    private int tr_barricade;
    private int tr_sandbag;
    
    private void Start()    /* Init at beginning of run */
    {
        mt_wood = 0;
        mt_stone = 0;
        mt_iron = 0;

        pt_planks = 0;
        pt_rivets = 0;
        pt_bricks = 0;
        pt_pebbles = 0;

        tr_wolftrap = 0;
        tr_barricade = 0;
        tr_sandbag = 0;
    }

    //Increment materials
    public void AddWood(int get)
    {
        mt_wood += get;
    }

    public void UseWood(int consume)
    {
        mt_wood -= consume;
    }

    public void AddStone(int get)
    {
        mt_stone += get;
    }

    public void UseStone(int consume)
    {
        mt_stone -= consume;
    }

    public void AddIron(int get)
    {
        mt_iron += get;
    }

    public void UseIron(int consume)
    {
        mt_iron -= consume;
    }

    //Increment Parts
    public void AddPlanks(int get)
    {
        pt_planks += get;
    }

    public void UsePlanks(int consume)
    {
        pt_planks -= consume;
    }

    public void AddRivets(int get)
    {
        pt_rivets += get;
    }

    public void UseRivets(int consume)
    {
        pt_rivets -= consume;
    }

    public void AddBricks(int get)
    {
        pt_bricks += get;
    }

    public void UseBricks(int consume)
    {
        pt_bricks -= consume;
    }

    public void AddPebbles(int get)
    {
        pt_pebbles += get;
    }

    public void UsePebbles(int consume)
    {
        pt_pebbles -= consume;
    }

    //IncrementTraps
    public void AddWolfTrap(int get)
    {
        tr_wolftrap += get;
    }

    public void UseWolfTrap(int consume)
    {
        tr_wolftrap -= consume;
    }

    public void AddBarricade(int get)
    {
        tr_barricade += get;
    }

    public void UseBarricade(int consume)
    {
        tr_barricade -= consume;
    }

    public void AddSandbag(int get)
    {
        tr_sandbag += get;
    }

    public void UseSandbag(int consume)
    {
        tr_sandbag -= consume;
    }
}
