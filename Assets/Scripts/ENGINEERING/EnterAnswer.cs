using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnterAnswer : MonoBehaviour
{
    public string Answer;
    public GameObject inputField;
    public GameObject textDisplay;
    private int[] randomNP;
    private int[] answersRN = { 14, 7, 17, 15, 6, 11, 31, 65, 20, 3, 38, 24, 5, 18 };
    private int[] answersRA1 = { 3, 3, 1, 4, 4, 4, 6, 2, 1, 6, 3, 3, 6, 1 };
    private int[] answersRA2 = { 6, 3, 2, 4, 5, 5, 4, 3, 2, 6, 1, 6, 4, 5 };
    private int i = 0;
    private bool RNScene = false;
    private bool RA1Scene = false;
    private bool RA2Scene = false;
    private int answerN;
    private int scoreRN = 0;
    private int scoreRA = 0; 

    private void OnGUI()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Level 1")
        {
            RNScene = true;
        } 
        else if (scene.name == "Level 2")
        {
            RA1Scene = true;
        }
        else if (scene.name == "Level 3")
        {
            RA2Scene = true;
        }

    }
    
    public void ReceiveRandomNProblems(int[] randomNProblems)
    {
        randomNP = randomNProblems;
    }
    public void StoreAnswer()
    {
        Answer = inputField.GetComponent<Text>().text;

        answerN = Int32.Parse(Answer);

        if (RNScene)
        {
            if (answersRN[randomNP[i]] == answerN)
            {
                textDisplay.GetComponent<Text>().text = "Respuesta Correcta";
                scoreRN++;
                
            } else
            {
                textDisplay.GetComponent<Text>().text = "Respuesta Incorrecta";
            }
            
        }
        else if (RA1Scene)
        {
            if (answersRA1[randomNP[i]] == answerN)
            {
                textDisplay.GetComponent<Text>().text = "Respuesta Correcta";
                scoreRA++;
            }
            else
            {
                textDisplay.GetComponent<Text>().text = "Respuesta Incorrecta";
            }
        }
        else if (RA2Scene)
        {
            if (answersRA2[randomNP[i]] == answerN)
            {
                textDisplay.GetComponent<Text>().text = "Respuesta Correcta";
                scoreRA++;
            }
            else
            {
                textDisplay.GetComponent<Text>().text = "Respuesta Incorrecta";
            }
        }


        i++;
    }
}
