using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class UI_Setting : MonoBehaviour
{
    public GameObject gameOverTextObj = default;
    public TMP_Text timeTextObj = default;
    public TMP_Text bestText = default;
    private float surviveTime = default;
    private bool isGameOver = false;
    Player_State state = default;

    private const string BEST_TIME_RECORD  = "BestTime";
    private const string SCENE_NAME = "SampleScene";
    // Start is called before the first frame update
    void Awake()
    {

    }
    void Start()
    {
        // state = GameManager.Instance.StateCall();
        surviveTime = 0f;
        isGameOver = false;
        gameOverTextObj.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            timeTextObj.text = $"Time : {Mathf.FloorToInt(surviveTime)} ";
            if(Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene(SCENE_NAME);
                gameOverTextObj.SetActive(false);
            }
        }
        
            surviveTime += Time.deltaTime;

            timeTextObj.text = $"Time : {Mathf.FloorToInt(surviveTime)} ";

    }
    public void EndGame()
    {
        isGameOver = true;
        gameOverTextObj.SetActive(true);
        gameOverTextObj.transform.localScale = Vector3.one;

        float bestTime = PlayerPrefs.GetFloat(BEST_TIME_RECORD);

        if(bestTime < surviveTime){
            bestTime = surviveTime;
            PlayerPrefs.SetFloat(BEST_TIME_RECORD, bestTime);

        }
        bestText.text = $"Best Time : {Mathf.FloorToInt(bestTime)}";
    }
}
