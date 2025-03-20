using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        int k = 1;
        for (int i = 1; i<=n;i++){
            if(i%2==1){
                Array.Resize(ref answer, k);
                answer[k-1] = i;
                k++;
            }
        }
        return answer;
    }
}