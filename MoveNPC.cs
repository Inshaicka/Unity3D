using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    //Здоровье
    public int health = 5;
    //Уровень
    public int level = 1;
    //Скорость NPC
    public float speed = 0.1f;
    //Положение NPC
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Ваше здоровье:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
