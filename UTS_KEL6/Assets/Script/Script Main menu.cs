using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMainmenu : MonoBehaviour
{
    public void BtnMulai()
    {
        SceneManager.LoadScene("HomeMain");
    }
    public void BtnHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void  RumahBaruga(){
    SceneManager.LoadSceneAsync(2);
   }
    public void  RumahHonai(){
    SceneManager.LoadSceneAsync(3);
   }
    public void  RumahKabaya(){
    SceneManager.LoadSceneAsync(4);
   }
    public void  RumahNuwoSesat(){
    SceneManager.LoadSceneAsync(5);
   }
      public void  RumahTongkonan(){
    SceneManager.LoadSceneAsync(6);
   }

    public void BtnKeluar()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}
