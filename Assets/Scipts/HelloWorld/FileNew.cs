//[1] 네임스페이스 선언부                                                                //:주석(컴파일할때 무시)
using UnityEngine; //현재 cs(시샵 스크립트) 파일에서 UnityEngine이라는 네임스페이스를 사용

//[2] 클래스 선언부
public class FileNew : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //[3] Start 메서드 선언 : 프로그램을 시작할때 1번만 실행
    void Start()   //Start라는 함수
    {
        //[5] 출력 명령문
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    //[4] Update 메서드 선언 : 프로그램 시작후 매 프레임마다 실행    //1초에 10번을 돌수도,30번을 돌수도, 60번을 돌수도, 300번을 돌수도 있다.
    void Update() //Update라는 함수     
    {
        
    }
}   //중괄호:코드블록 이라고 부르신다

