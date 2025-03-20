using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int ArrayLen = num_list.Length;
        int[] answer = new int[ArrayLen];
        for (int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[ArrayLen - i -1];
        }
        return answer;
    }
}