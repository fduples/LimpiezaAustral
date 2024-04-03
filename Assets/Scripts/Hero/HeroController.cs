using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private Rigidbody2D _heroRB;
    private Vector2 _v;
    // Start is called before the first frame update

    private void Awake()
    {
        //_v = new Vector2(_speed, 0);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _v = new Vector2(_speed, 0);
        _heroRB.velocity = _v;
    }
}
