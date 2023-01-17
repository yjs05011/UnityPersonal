using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    public float bulletSpeed = 8.0f; 
    Player_State state = default;
    private Rigidbody BulletRg = default;

    void Awake(){
        BulletRg = gameObject.GetComponent<Rigidbody>();
        BulletRg.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 3.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
    //    state = GameManager.Instance.StateCall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other){
        if(other.tag.Equals("Player")){
            Player_Controler player = other.GetComponent<Player_Controler>();
            if(player == null || player == default){
                return;
            }

            Destroy(gameObject);
            
            player.Die();
        }
    }
    // public void Attacked(Collision collision)
    // {
    //     if (collision.collider.gameObject.CompareTag("player"))
    //     {
    //         state.player_hp -= 1;
    //         Destroy(gameObject);
    //         Debug.Log(state.player_hp);
    //     }
    // }


}
