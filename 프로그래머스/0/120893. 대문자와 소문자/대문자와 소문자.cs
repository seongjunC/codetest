using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach (char str in my_string){
            bool strLower = Char.IsLower(str);
            if(strLower){
                answer += Char.ToUpper(str);
            } 
            else{
                answer += Char.ToLower(str);
            }
        }
        return answer;
    }
}