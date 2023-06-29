using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator animator;
    public KeyCode keyanimationon;
    public KeyCode keyanimationoff;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        animator.SetBool("fly", false);
    }
    // Update is called once per frame
    void Update()
    {
        Satanimation();
    }

    private void Satanimation()
    {
        if (Input.GetKey(keyanimationon))
            animator.SetBool("fly", true);

        else if (Input.GetKey(keyanimationoff))
            animator.SetBool("fly", false);
    }
}
