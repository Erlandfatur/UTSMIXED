using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMainmenu : MonoBehaviour
{
    public void  RumahBaruga(){
    SceneManager.LoadSceneAsync(1);
   }
    public void  RumahHonai(){
    SceneManager.LoadSceneAsync(2);
   }
    public void  RumahKabaya(){
    SceneManager.LoadSceneAsync(3);
   }
    public void  RumahNuwoSesat(){
    SceneManager.LoadSceneAsync(4);
   }
      public void  RumahTongkonan(){
    SceneManager.LoadSceneAsync(5);
   }
}
