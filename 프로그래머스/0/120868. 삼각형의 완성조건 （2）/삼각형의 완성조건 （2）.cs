using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        Array.Sort(sides);
        int minNum = sides[1] - sides[0];
        int maxNum = sides[1] + sides[0];
        if (minNum == maxNum){
            answer = 0;
        }
        else{
            answer = maxNum - minNum - 1;
        }
        return answer;
    }
}