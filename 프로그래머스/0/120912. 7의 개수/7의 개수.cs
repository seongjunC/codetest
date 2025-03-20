using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        foreach (int i in array){
            int arrInt = i;
            while(arrInt != 0){
                if(arrInt % 10 == 7){
                    answer += 1;
                }
                arrInt /= 10;
            }
        }
        return answer;
    }
}