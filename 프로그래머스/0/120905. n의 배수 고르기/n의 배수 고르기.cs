using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[] {};
        int k = 1;
        foreach(int i in numlist){
            if( i % n == 0){
                Array.Resize(ref answer, k);
                answer[k-1] = i;
                k++;
            }
        }
        return answer;
    }
}