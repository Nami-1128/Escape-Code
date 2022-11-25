using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDetectionSistem : MonoBehaviour
{
    public string[] textCommands;
    public TMP_Text consoleText;
    public Transform botTransform;
    public bool moveForward = false;
    bool textEnter = false;

    void Update()
    {
        void OnTriggerStay(Collider collision)
        {
            if (collision.gameObject.CompareTag("baldosas") && textEnter==true)
            {
                if(consoleText.text == textCommands[0]){
                consoleText.text = " ";
                moveForward = true;
                MoveForward();}

                if(consoleText.text == textCommands[1]){
                consoleText.text = " ";
                moveForward = true;
                MoveForward();
                MoveForward();}

                if(consoleText.text == textCommands[2]){
                consoleText.text = " ";
                moveForward = true;
                MoveForward();
                MoveForward();
                MoveForward();}

                if(consoleText.text == textCommands[3]){
                consoleText.text = " ";
                moveForward = true;
                MoveForward();
                MoveForward();
                MoveForward();
                MoveForward();}

                consoleText.text = " ";
                textEnter = false;
            }

        }
        consoleText.text = " ";
        textEnter = false;
    }
    
    void MoveForward()
    {
        void OnTriggerStay(Collider collision){
        if(collision.gameObject.CompareTag("baldosas"))
        {
            
        }}
    }
    
    public void TextEnter()
    {
        textEnter = true;
        Debug.Log(consoleText.text);
        consoleText.text = "";
    }
}
