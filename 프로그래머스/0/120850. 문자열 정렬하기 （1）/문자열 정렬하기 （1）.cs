using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[] {};
        int k = 0;
        foreach (char cha in my_string){
            string str = cha.ToString();
            bool isInt = int.TryParse(str, out int i);
            if (isInt){
                Array.Resize(ref answer, ++k);
                answer[k-1] = i;
            }
        }
        Array.Sort(answer);
        return answer;
    }
}