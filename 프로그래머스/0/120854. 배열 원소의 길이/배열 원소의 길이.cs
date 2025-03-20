using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[] {};
        int listLen = strlist.Length;
        int i = 0;
        Array.Resize(ref answer,listLen);
        foreach (string str in strlist){
            answer[i] = str.Length;
            i++;
        }
        
        return answer;
    }
}