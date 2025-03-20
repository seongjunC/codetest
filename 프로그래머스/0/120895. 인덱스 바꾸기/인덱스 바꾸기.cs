using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        char str1 = my_string[num1];
        char str2 = my_string[num2];
        int k = 0;
        foreach(char str in my_string){
            if( k == num1){
                answer += str2;
            }
            else if(k == num2){
                answer += str1;
            }
            else{
                answer += str;  
            }  
            k++;
        }
        return answer;
    }
}