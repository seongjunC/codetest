using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[] {};
        Array.Resize(ref answer, 2);
        int numer3 = numer1*denom2 + numer2*denom1;
        int denom3 = denom1*denom2;
        int temp = 0;
        int remain = 0;
        int n = numer3;
        int m = denom3;
        if (n<m){
            temp =n;
            n = m;
            m = temp;
        }
        while (m != 0){
            remain = n % m;
            n = m;
            m = remain;
        }
        answer[0] = numer3 / n;
        answer[1] = denom3 / n;
        return answer;
    }
}