using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionPlayerObjek : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text TextScore;
    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag=="Enemy"){
        	score++;
        	TextScore.text="Score = "+score.ToString();
        	Destroy(coll.gameObject);
        }
    }
    void OnGUI(){
        GUI.color=Color.white;
        GUILayout.Label("Score = "+score.ToString());
    }
 }
