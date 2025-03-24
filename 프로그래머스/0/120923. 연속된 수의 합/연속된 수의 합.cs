using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        for(int i = -num; i<=total; i++){
            if (( 2*i +num-1)*num/2 == total){
                for(int j =0; j<num; j++){
                    answer[j] = i+j;
                }
                break;
            }
        }
        return answer;
    }
}