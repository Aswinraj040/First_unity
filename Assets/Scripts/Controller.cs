using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{
    public GameObject TurbineObject;
    public GameObject PistonObject;
    public GameObject HullObject;
    public GameObject GridObject;
    private bool isActive1 = true;
    public Button newscene;
    private bool isActive2 = true;
    private bool isActive3 = true;
    private bool isActive4 = true;
    public void button1(){
        if(isActive1){
            TurbineObject.SetActive(false);
            isActive1 = false;
        }
        else{
            TurbineObject.SetActive(true);
            isActive1 = true;
        }
    }
    public void button2(){
        if(isActive2){
            PistonObject.SetActive(false);
            isActive2 = false;
        }
        else{
            PistonObject.SetActive(true);
            isActive2 = true;
        }
    }
    public void button3(){
        if(isActive3){
            HullObject.SetActive(false);
            isActive3 = false;
        }
        else{
            HullObject.SetActive(true);
            isActive3 = true;
        }
    }
    public void button4(){
        if(isActive4){
            GridObject.SetActive(false);
            isActive4 = false;
        }
        else{
            GridObject.SetActive(true);
            isActive4 = true;
        }
    }
    public void Newsceneload()
    {
        SceneManager.LoadScene("Second");
    }  
}
