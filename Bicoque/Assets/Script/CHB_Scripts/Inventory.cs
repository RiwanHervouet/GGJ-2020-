using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //Materials
    private int mt_wood;
    private int mt_stone;
    private int mt_iron;

    [SerializeField]
    private GameObject woodCount;
    [SerializeField]
    private GameObject stoneCount;
    [SerializeField]
    private GameObject ironCount;

    private Text woodText;
    private Text ironText;
    private Text stoneText;

    //Traps
    private int tr_wolftrap;
    private int tr_barricade;
    private int tr_sandbag;

    [SerializeField]
    private GameObject wolftrapCount;
    [SerializeField]
    private GameObject barricadeCount;
    [SerializeField]
    private GameObject sandbagCount;

    private Text wolftrapText;
    private Text barricadeText;
    private Text sandbagText;

    private void Start()    /* Init at beginning of run */
    {
        mt_wood = 0;
        mt_stone = 0;
        mt_iron = 0;

        tr_wolftrap = 0;
        tr_barricade = 0;
        tr_sandbag = 0;

        woodText = woodCount.GetComponent<Text>();
        ironText = ironCount.GetComponent<Text>();
        stoneText = stoneCount.GetComponent<Text>();

        wolftrapText = wolftrapCount.GetComponent<Text>();
        barricadeText = barricadeCount.GetComponent<Text>();
        sandbagText = sandbagCount.GetComponent<Text>();

        UpdateCounters();
    }

    private void Update()
    {
        
    }

    public void UpdateCounters()
    {
        woodText.text = mt_wood.ToString();
        stoneText.text = mt_stone.ToString();
        ironText.text = mt_iron.ToString();

        wolftrapText.text = tr_wolftrap.ToString();
        barricadeText.text = tr_barricade.ToString();
        sandbagText.text = tr_sandbag.ToString();
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
