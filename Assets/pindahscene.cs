using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahscene : MonoBehaviour {

	public void pindahScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Back(){
		SceneManager.LoadScene ("Utama");
	}

	public void Easy(){
		SceneManager.LoadScene ("Easy");
	}

	public void Medium(){
		SceneManager.LoadScene ("Medium");
	}

}
