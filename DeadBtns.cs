using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadBtns : MonoBehaviour
{
    public Animator animator;

   //Dead button here

    public void PlayAgain()
    {
        animator.SetTrigger("exit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        animator.SetTrigger("exit");
        Application.Quit();
        Debug.Log("Game is over Dead Person"); 
    }
}
