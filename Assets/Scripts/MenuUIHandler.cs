using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public static string playerName = "";
    public GameObject inputField;
    public GameObject highScore;
    public Text ScoreText1;
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(ScoreText1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void ReadStringInput()
    {
        playerName = inputField.GetComponent<InputField>().text;
        //Debug.Log(playerName + "test");
        //ScoreText1.text = "Player Name: " + playerName;
        //DontDestroyOnLoad(gameObject);
    }


}


