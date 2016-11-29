using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance=null;

    void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
