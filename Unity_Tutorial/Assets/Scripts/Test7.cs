using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour
{

    private Animation anim;

    private AnimationClip clip;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            ////기본재생 - 큐브1 끝내고
            //anim.Play("Cube_2");
            ////큐브1 끝나고 큐브2 재생
            //anim.PlayQueued("Cube_2");
            //같이 재생
            anim.Blend("Cube_2");
            ////실행되던게 자연스럽게 사라지고 재생
            //anim.CrossFade("Cube_2");
            ////플레이중이라면 트루반환
            //if(!anim.IsPlaying("Cube_2"))
            //{
            //    anim.Play("Cube_2");
            //}
            //멈춤
            //anim.Stop();

            //애니메이션 종류 변경
            //anim.wrapMode = WrapMode.Loop;

            //클립변경
            //anim.clip = clip;
        }
    }
}
