using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExitGame : MonoBehaviour {
    public Button yourButton;

    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
        Debug.Log ("Exit Game!");
        /*
         * RoomFirstGenerator().createRoom();
         *
         * protec override void runproceduralgeneration
         * RoomFirstGenerator.createRooms()
         */
        
    }
}
