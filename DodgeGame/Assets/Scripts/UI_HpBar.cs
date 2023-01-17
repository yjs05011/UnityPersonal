using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_HpBar : MonoBehaviour
{

    public Slider hpbar = default;
    private Player_State state = default;
    // Start is called before the first frame update
    void Start()
    {
        // hpbar = GetComponent<Slider>();
        // state = GameManager.Instance.StateCall(); //캐릭터 hp를 받아옴
    } 

    // Update is called once per frame
    void Update()
    {
    }
    public void PlayerHPbar()

    {

       
        if(state.Player_hp <= 0){
            hpbar.gameObject.SetActive(false);
        }else{
            hpbar.gameObject.SetActive(true);
            hpbar.value = state.Player_hp;
        }

        

    }
}

