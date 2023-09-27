using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Libreria para trabajar el cambio de escenas
using UnityEngine.SceneManagement;

// Libreria para trabajar con las UI de Unity
using UnityEngine.UI;

// Libreria para trabajar con el TextMesh Pro
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    /// <summary>
    /// Este método me va a cambiar la escena según el valor del Build Settings
    /// </summary>
    /// <param name="value"> posicion en el build settings</param>
    public void ChangeScene(int value)
    {
        SceneManager.LoadScene(value);
    }

    /// <summary>
    /// Este método me va a cambiar la escena según el nombre de la escena
    /// </summary>
    /// <param name="nameScene"> el nombre de la escena</param>
    public void ChangeScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);  
    }

    /// <summary>
    /// Método para cerrar la apk
    /// </summary>
    public void CloseApp()
    {
        Application.Quit();
        Debug.Log("Se va a cerrar la aplicación");
    }

}
