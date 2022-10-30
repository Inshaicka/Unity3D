using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNPC : MonoBehaviour
{
    //��������
    public int health = 5;
    //�������
    public int level = 1;
    //�������� NPC
    public float speed = 0.1f;
    //��������� NPC
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("���� ��������:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
