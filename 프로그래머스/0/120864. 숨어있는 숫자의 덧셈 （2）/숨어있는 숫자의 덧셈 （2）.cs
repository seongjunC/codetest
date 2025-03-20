using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int strNum = 0;
        int sumNum = 0;
        bool beforeNum = false;
        foreach(char str in my_string){
            bool isNum = int.TryParse(str.ToString(), out strNum);
            if(!isNum){
                answer += sumNum;
                sumNum = 0;
                beforeNum = false;
            }
            else{
                beforeNum = true;
                sumNum *= 10;
                sumNum += strNum;
            }
        }
        if(beforeNum){
            answer+=sumNum;
        }
        return answer;
    }
}