using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string[] stringArr = s.Split(" ");
        int beforeNum = 0;
        foreach(string str in stringArr){
            int nowNum = 0;
            bool isNum = int.TryParse(str, out nowNum);
            if(isNum){
                answer += nowNum;
                beforeNum = nowNum;
            }
            else{
                answer -= beforeNum;
            }
        }
        return answer;
    }
}