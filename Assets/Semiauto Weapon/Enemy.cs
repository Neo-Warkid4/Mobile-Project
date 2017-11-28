using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int health;

    void Update ()
    {
        Debug.Log(health.ToString());
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
