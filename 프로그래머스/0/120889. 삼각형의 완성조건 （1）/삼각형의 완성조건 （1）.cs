using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int third = 0;
        int first = 0;
        int second = 0;
        int isTriangle = 0;
        if (sides[0] - sides[1] > 0){
            first = sides[0];
            third = sides[1];
        }
        else{
            first = sides[1];
            third = sides[0];
        }
        if (first - sides[2] > 0){
            second = first;
            first = sides[2];
        }
        else{
            second = sides[2];
        }
        if (second >= first +third){
            answer = 2;
        }
        else{
            answer = 1;
        }
        
        return answer;
    }
}