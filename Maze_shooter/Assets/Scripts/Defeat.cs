using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defeat : MonoBehaviour {


    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Enemy")
        {
        //SceneManager.LoadScene("You were not prepared, scene");
        SceneManager.LoadScene("DefeatScene");

        }
    }
}
