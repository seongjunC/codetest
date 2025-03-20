using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        int SaleDrink = (n /10);
        k -= SaleDrink;
        answer = n*12000 + k *2000;
        return answer;
    }
}