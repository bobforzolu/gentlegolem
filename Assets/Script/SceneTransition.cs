using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private string[] scenes; // List of scene names to transition to
    private int currentSceneIndex = 0; // Index of current scene in the scenes array

    private void Start()
    {
        // Load the first scene in the scenes array
        //SceneManager.LoadScene(scenes[currentSceneIndex], LoadSceneMode.Additive);
    }

  

    public void TransitionToScene(int sceneIndex)
    {
        if (sceneIndex < 0 || sceneIndex >= scenes.Length)
        {
            Debug.LogWarning("Invalid scene index.");
            return;
        }

        

        // Load the new scene
        SceneManager.LoadScene(scenes[sceneIndex]);

        // Set the new current scene index
        currentSceneIndex = sceneIndex;
    }

    public void TransitionToNextScene()
    {
        // Increment the current scene index
        currentSceneIndex++;

        // If the current scene index is out of bounds, wrap around to 0
        if (currentSceneIndex >= scenes.Length)
        {
            currentSceneIndex = 0;
        }

        // Transition to the next scene
        TransitionToScene(currentSceneIndex);
    }
}
