using System;

public class Solution {
    public int solution(int[] dot) {
        int answer = 0;
        int num1 = dot[0];
        int num2 = dot[1];
        if (num1 > 0){
            if(num2 > 0){
                answer += 1;
            }
            else{
                answer += 4;
            }
        }
        else{
            if(num2 > 0){
                answer += 2;
            }
            else{
                answer +=3;
            }
        }
        return answer;
    }
}