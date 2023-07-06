using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_level : MonoBehaviour
{
    public void Changelevel()
    {
        if (SceneManager.GetActiveScene().name == "scene_town")
            SceneManager.LoadScene("scene_cave");
        else
            SceneManager.LoadScene("scene_town");
    }

}
