using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        int numLen = numbers.Length;
        int k = 0;
        foreach(int i in numbers){ 
            answer[k] = 2 * i;
            k++;
        }
        return answer;
    }
}