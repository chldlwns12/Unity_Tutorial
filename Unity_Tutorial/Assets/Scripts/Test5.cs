using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    [SerializeField]
    private GameObject go_Target;
    
    [SerializeField]
    private float speed;
    
    private Vector3 difVealue;

    //private Camera theCam;

    // Start is called before the first frame update
    void Start()
    {
        difVealue = transform.position - go_Target.transform.position;
        //difVealue = new Vector3(Mathf.Abs(difVealue.x), Mathf.Abs(difVealue.y), Mathf.Abs(difVealue.z));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, go_Target.transform.position + difVealue, speed);
    }
}
