//#define LOG_TRACE_INFO
//#define LOG_EXTRA_INFO

using UnityEngine;
using System.Collections;

//------------------------------------------------------------------------------
// class definition
//------------------------------------------------------------------------------
public class MenuController : MonoBehaviour
{

	//public GameObject buttonPlay;


	private MenuController menuController;

	//--------------------------------------------------------------------------
	// public static methods
	//--------------------------------------------------------------------------
	//--------------------------------------------------------------------------
	// protected mono methods
	//--------------------------------------------------------------------------
	protected void Awake()
	{

		menuController = this;
	}
	
	protected void OnDestroy()
	{
		if(menuController != null)
		{
			menuController = null;
		}
	}

	public void SwitchSceneToGame(){
		MainController.SwitchScene("Game Scene");
	}
	public void SwitchSceneToSettings(){
		MainController.SwitchScene("Settings");
	}
	public void SwitchSceneToFacebook(){
		
		MainController.SwitchScene("main_scene");

	}
	public void rate(){
		//Debug.Log ("rate");
		Application.OpenURL("http://slackball.com");
	}
	
	protected void OnDisable()
	{
	}
	
	protected void OnEnable()
	{
	}
	
	protected void Start()
	{
	}
	
	protected void Update()
	{
		if(Input.GetMouseButtonDown(0) == true)
		{
			//MainController.SwitchScene("main_scene");
		}
	}

	//--------------------------------------------------------------------------
	// private methods
	//--------------------------------------------------------------------------
}
