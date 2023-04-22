using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverRoca : MonoBehaviour
{
    private Rigidbody2D rig;

    public float speed;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rig.velocity = new Vector2(0, speed);
    }
}
