using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        Array.Resize(ref answer, 2);
        foreach( int i in num_list){
            if(i%2 == 0){
                answer[0] +=1;
            }
            else{
                answer[1] +=1;
            }
        }
        return answer;
    }
}