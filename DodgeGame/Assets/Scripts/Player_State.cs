using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_State : MonoBehaviour
{
    [SerializeField]
    private float player_hp;
    public float player_SPEED =8f;
    public float Player_hp {
        get;set;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Player_hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
