using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        int k = 1;
        for( int i = 1; i <= n; i++){
            if (n%i == 0){
                Array.Resize(ref answer, k);
                answer[(k-1)] = i;
                k++;
            }
        }
        return answer;
    }
}