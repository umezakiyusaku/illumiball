using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetector : MonoBehaviour
{
    public GameObject holeRed;
    public GameObject holeBlue;
    public GameObject holeGreen;

    // Update is called once per frame
    void OnGUI()
    {
        //すべてのボールが入ったらラベルを表示
        if(holeRed.GetComponent<Hole>()&&holeBlue.GetComponent<Hole>()&&holeGreen.GetComponent<Hole>())
        {
            GUI.Label(new Rect(50, 50, 100, 30), "Game Clear!");
        }
    }
}
