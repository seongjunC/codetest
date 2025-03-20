using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[] {};
        int numPurchase = money / 5500;
        int numChange = money % 5500;
        Array.Resize(ref answer, 2);
        answer[0] = numPurchase;
        answer[1] = numChange;
        return answer;
    }
}