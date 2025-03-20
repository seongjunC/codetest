using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] ArrChar = s.ToCharArray();
        Array.Sort(ArrChar);
        for (int i = 0; i < s.Length; i++){
            if(i == 0 && s.Length == 1){
                answer += ArrChar[0];
            }
            else if(i == 0){
                if(ArrChar[0] != ArrChar[1]){
                    answer += ArrChar[0];
                }
            }
            else if(i == s.Length - 1){
                if(ArrChar[i] != ArrChar[i-1]){
                    answer += ArrChar[i];
                }
            }
            else{
                if(ArrChar[i-1] != ArrChar[i] && ArrChar[i]!= ArrChar[i+1]){
                    answer += ArrChar[i];
                }
            }
        }
        return answer;
    }
}