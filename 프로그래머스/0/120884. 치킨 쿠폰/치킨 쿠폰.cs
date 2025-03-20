using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        int chickenDiv = chicken;
        int chickenOne = 0;
        while(chickenDiv != 0){
            chickenOne += chickenDiv % 10;
            chickenDiv /= 10;
            answer += chickenDiv;
        }
        while(chickenOne != 0){
            int n = 0;
            if( chickenOne / 10 != 0){
                n += chickenOne / 10;
                chickenOne %= 10;
                chickenOne += n;
                answer += n;
            }
            else{
                break;
            }
        }
        return answer;
    }
}