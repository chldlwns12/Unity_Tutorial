using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Test : MonoBehaviour
{
    Vector3 rotation;
    [SerializeField]
    private GameObject go_camera;

    void Start()
    {
        //rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //이동
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime; // 60분의 1
            //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);

            //앵글
            //this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;
            //Debug.Log(transform.eulerAngles);

            //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);

            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;   //한축을 고정했을때 다른축의 회전이 고장하는 상황이 생기는데 짐볼락(?) 이라고 한다.
            //this.transform.rotation = Quaternion.Euler(rotation);           //Quaterniom 을 쓰는이유는 짐볼락이 생기지 않는다.

            //크기
            //this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;

            //대표적인 속성 예
            //moveSpeed * this.transform.forward * Time.deltaTime  //정규화 벡터(방향만을 알려주는 녀석) new Vector3(0,0,1)
            //moveSpeed * this.transform.up * Time.deltaTime  //정규화 벡터(방향만을 알려주는 녀석) new Vector3(0,1,0)
            //moveSpeed * this.transform.right * Time.deltaTime  //정규화 벡터(방향만을 알려주는 녀석) new Vector3(1,0,0)

            //원하는 오브젝트 바라보기
            //this.transform.LookAt(go_camera.transform.position);
        }
        //오브젝트를 중심으로 공전하기
        //transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
