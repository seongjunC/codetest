using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        foreach(char str in my_string){
            string strChar = str.ToString();
            bool isInt = int.TryParse(strChar, out int arrayInt);
            answer += arrayInt;
        }
        return answer;
    }
}