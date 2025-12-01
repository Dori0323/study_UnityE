using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Control : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int a;
    public int b;
    // public int c, d; // 위의 a, b과 동일한 공식
    public string fruit;

    void Start()
    {
        ///*if문 의 예시*/
        //if (a > b)
        //{
        //    Debug.Log("a가 b보다 큽니다.");

        //}
        //else if (a < b)
        //{
        //    Debug.Log("b가 a보다 큽니다.");
        //}
        //else
        //{
        //    Debug.Log("a와 b는 같습니다.");
        //}
        ///*Switch 의 예시*/
        //switch (this.fruit)
        //{
        //    case "사과":
        //        Debug.Log("사과는 빨갛습니다.");
        //        break;
        //    case "바나나":
        //        Debug.Log("바나나는 노랗습니다.");
        //        break;
        //    case "포도":
        //        Debug.Log("포도는 보라색입니다.");
        //        break;
        //    default:
        //        Debug.Log("알 수 없는 과일입니다.");
        //        break;
        //}
        ///*for문의 예시*/
        //for (int i = 0; i < 5; i++)             // for (int i = 0; i<5; i++){Debug.Log("i의 값: "+i);} 이 밑의 구문의 축약형
        //{                               // 처음 i는 0, C#의 for문은 우선 대입하고, for문을 실행한 후 증가시키기 때문에
        //    Debug.Log("i의 값: " + i); // 문자열과 변수를 같이 출력할 때는 + 기호를 사용.
        //}                                   // 해당 for문이 닫혀야 ++가 실행됨. ; 에 따라 적용되는 순서도 달라짐.

        ///*while 의 예시*/
        //while (a < 10)                      // while문, 조건문의 값을 만족할 때까지 반복.
        //{                                       // 위에서 조건문을 먼저 검사를 하기에, 9까지 출력이 됨.
        //    Debug.Log("a의 값: " + a);
        //    a++;
        //}
        ///*do while 의 예시*/
        //do                                  // Lua의 repeat과 유사함.
        //{                                       // 일단 실행하고 조건문을 검사함.
        //    Debug.Log("b의 값: " + b);   
        //    b++;
        //} while (b > 10);

        /*배열 의 예시*/
        // 딕셔너리 X 밑의 둘다 array
        // 밑에는 일단 빈칸 5개를 만든다. 0~4번까지.
        //string[] array = new string[5];      // 인덱스의 범위가 5까지인데, 6을 넣어버리면, 오류가 발생. 실행 조차도 안됌. (C#: 아.. 공간 없는데 뭘 때려넣어? 죽을게.)

        // lua 에서는 1부터 시작
        //array[0] = "강대원";
        //array[1] = "민영희";
        //array[2] = "박철수";
        //array[3] = "안선생";
        //array[4] = "함수빈";

        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(array[i]);           
        //}


        //// 순서대로 0부터 4번까지 넣기.
        //int[] scores = { 90, 85, 78, 92, 88 };

        //int[] arr1 = new int[3];
        //int[] arr2 = new int[5] { 12, 14, 35, 2, 54 };

        //for (int j = 0; j < 5; j++)
        //{
        //    Debug.Log("배열의 값: " + j + ":" + arr2[j]);
        //}

        // 2차원 배열 레이어를 생각하면 이해하기 쉬움.
        //string[,] zoo = new string[3, 3];

        //zoo[0,0] = "사자";
        //zoo[0,1] = "호랑이";
        //zoo[0,2] = "표범";
        //zoo[1,0] = "코끼리";
        //zoo[1,1] = "기린";
        //zoo[1,2] = "얼룩말";
        //zoo[2,0] = "원숭이";
        //zoo[2,1] = "침팬지";
        //zoo[2,2] = "고릴라";

        // // 3차원의 배열
        // // int[,,] newInt = new int[3, 4, 3,]; // 인트형으로 받는 법
        //string[,,] newZoo = new string[2, 2, 2];    // 문자열로 3차원 배열

        //newZoo[0, 0, 0] = "늑대";
        //newZoo[0, 0, 1] = "여우";

        //int[,] samsam = { { 1, 2, 3 }, { 4, 5, 6, }, { 7, 8, 9, }, { 10, 11, 12 } }; // 전채 배열 4개, 각 배열의 원소 3개씩 있으니 4x3 배열 따라서 samsam[3,2] 하면은 12
        //                                                                                // smasma[3,1] == 11, samsam[3,0] == 10
        //Debug.Log(samsam[3, 2]);

        /*
            List<자료형> 식별자 = new List<자료형>();
            식별자.Add(데이터);
            (...원하는 만큼 추가)
            // 추가 순서대로 인덱스 획득
        */

        List<string> studentList = new List<string>();
        // // Add는 칸을 생성해서 추가하는 것이고, Remove는 칸 자체를 삭제하는 것.
        studentList.Add("강대원"); 
        studentList.Add("민영희");
        studentList.Add("박철수");
        studentList.Add("안선생");
        studentList.Add("함수빈");

        //studentList.Remove("안선생"); // 안선생의 칸을 삭제
        //Debug.Log(studentList[3]);
        studentList.RemoveAt(1); // //

        for (int k = 0; k<studentList.Count; k++)       // 리스트의 총 길이로 안에 값들을 가져옴.
        {
            Debug.Log("학생 이름: " + studentList[k]); // 가져온 값들을 출력함.
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
