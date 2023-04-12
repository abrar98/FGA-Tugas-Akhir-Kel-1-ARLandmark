using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //string nama scene
    public string namaScene;

    //fungsi untuk ganti scene
    public void OnButtonClick()
    {
        SceneManager.LoadScene(namaScene);
    }

}
