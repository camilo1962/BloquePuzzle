using UnityEngine;
using System.Collections;

public class DeletAllPrefs : MonoBehaviour {

	
	void Start ()
	{
		//PlayerPrefs.DeleteAll ();
	}
	public void BorrarRecord()
	{
        PlayerPrefs.DeleteAll();
    }
}
