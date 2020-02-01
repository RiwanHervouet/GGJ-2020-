using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis : MonoBehaviour
{

    //1- Paramétrage

    //1.1- La vie du PNJ
    public int health = 1; //là au cas où
    private bool alive = true;

    //1.2- Vitesse + déplacement
    public float speed;
    public GameObject directionGO;      //centre de la maison
    private Vector3 direction;
    private bool canMove = true;

    //1.3- Rigid Body
    public Rigidbody2D rigidBody;

    //1.4- Attaques
    public float attackDelay;
    public float damage;


    //2- Void Start
    void Start()
    {

        //2.1- Récup de la coord
        direction = directionGO.transform.position;
        
        //2.2- Spawn des mobs

    }


    //3- Void Update
    void Update()
    {

        //3.1- Déplacement

        if (canMove == true)
        {

            rigidBody.velocity = direction * speed * Time.fixedDeltaTime;

        }


        //3.2- Attaque des protections


        //3.3- Vérification si il est en vie

        if (alive == false)
        {

            Destroy(gameObject);

        }

    }


    //4- On trigger events
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //4.1- Si il est en contact avec les barricades

        if (collision.gameObject.CompareTag("Barricade"))
        {

            StartCoroutine(Attaque());

        }


        //4.2- Si il est en contact avec des pièges
        if (collision.gameObject.CompareTag("Trap"))
        {

            alive = false;

        }

    }


    //5- Création de la coroutine d'attaque
    IEnumerator Attaque()
    {

        canMove = false;

        yield return new WaitForSeconds(attackDelay);



    }

}
