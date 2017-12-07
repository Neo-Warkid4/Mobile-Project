using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int health;

    private Destructible destructible;

    void Start()
    {
        destructible = gameObject.GetComponent<Destructible>();
    }
    void Update ()
    {
        //Debug.Log(health.ToString());
        if(health <= 0)
        {

            destructible.DestroyObject();
            //Destroy(gameObject);
        }
    }
}
