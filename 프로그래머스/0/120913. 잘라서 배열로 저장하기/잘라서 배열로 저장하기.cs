using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        int strLen = 0;
        if(my_str.Length % n == 0){
            strLen = my_str.Length/n;
        }
        else{
            strLen = my_str.Length/n+1;
        }
        string[] answer = new string[strLen];
        char[] charArr = my_str.ToCharArray();
        for(int i = 0; i<strLen; i++){
            string ansArr = "";
            for(int j = 0; j<n; j++){
                if(n*i+j < my_str.Length){
                    ansArr += charArr[n*i+j];
                }
            }
            answer[i] += ansArr;
        }
        
        return answer;
    }
}