using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuChooser : MonoBehaviour {

	public void ChangeScene(string scenePath) {
		SceneManager.LoadScene (scenePath);
	}

	public void QuitRequest(){
		Application.Quit();
	}
		

}
