using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        foreach(char str in rsp){
            if (str == '0'){
                answer += "5";
            }
            else if(str =='2'){
                answer += '0';
            }
            else{
                answer += "2";
            }
        }
        return answer;
    }
}