using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHideTextLabels : MonoBehaviour {

    GameObject textLabels;
    public Button m_YourFirstButton, m_YourSecondButton;

   	// Use this for initialization
	void Start () {

        textLabels = GameObject.Find("/HitCubeParent/TextLabels");
        FindButtonsInScene();

       


	}

    void FindButtonsInScene(){
        Button btn1 = m_YourFirstButton.GetComponent<Button>();
        Button btn2 = m_YourSecondButton.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(TaskOnClick2);
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        textLabels.SetActive(false);
    }

    void TaskOnClick2()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        textLabels.SetActive(true);
    }
	

}
