using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controler : MonoBehaviour
{

    public UI_Setting setting = default;
    private Rigidbody PlayerRgBody = default;
    private Player_State state = default;
    private Player_Controler player = default; 
    public float player_Speed= 8.0f;
    UI_Setting UiSetting = default;

    int KeyType = 0;
    // Start is called before the first frame update


    void Awake()
    {
        PlayerRgBody = gameObject.GetComponent<Rigidbody>();
    }
    void Start()
    {
        // state = GameManager.Instance.StateCall();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(state.Player_hp);
        if (Input.GetKey(KeyCode.F1))
        {
            KeyType = 1;
            Debug.Log("KeyType = move");
        }
        else if (Input.GetKey(KeyCode.F2))
        {
            KeyType = 2;
            Debug.Log("KeyType = Newmove");
        }
        else if (Input.GetKey(KeyCode.F3))
        {
            KeyType = 3;
            Debug.Log("KeyType = Legacymove");
        }
        switch (KeyType)
        {
            case 1:
                Move();
                break;
            case 2:
                NewMove();
                break;
            case 3:
                LegacyMove();
                break;
            default:
                break;
        }
       
    }

    public void Die()
    {
        gameObject.SetActive(false);
        setting.EndGame();
    }
    public void LegacyMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRgBody.AddForce(new Vector3(0, 0, player_Speed));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ;
            PlayerRgBody.AddForce(new Vector3(0, 0, -player_Speed));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ;
            PlayerRgBody.AddForce(new Vector3(player_Speed, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerRgBody.AddForce(new Vector3(-player_Speed, 0, 0));
        }

    }
    public void NewMove()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * player_Speed;
        float zSpeed = zInput * player_Speed;

        Vector3 playerVelo = new Vector3(xSpeed, 0f, zSpeed);

        PlayerRgBody.velocity = playerVelo;
    }
    public void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRgBody.MovePosition(PlayerRgBody.position + Vector3.forward * Time.deltaTime * player_Speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerRgBody.MovePosition(PlayerRgBody.position + Vector3.left * Time.deltaTime * player_Speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerRgBody.MovePosition(PlayerRgBody.position + Vector3.right * Time.deltaTime * player_Speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            PlayerRgBody.MovePosition(PlayerRgBody.position + Vector3.back * Time.deltaTime * player_Speed);
        }
    }

}
