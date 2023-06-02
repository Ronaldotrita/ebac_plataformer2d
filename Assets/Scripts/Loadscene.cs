using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    public void load(int i)
    {
        SceneManager.LoadScene(i);

    }
    public void load(string s)
    {
        SceneManager.LoadScene(s);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
