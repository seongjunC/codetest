using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] stringArr = my_string.Split(' ');
        int sum = 0;
        char op = ' ';
        foreach(string str in stringArr){
            bool isNum = int.TryParse(str, out int num);
            if(isNum){
                if(sum == 0){
                    sum += num;
                }
                else if(op == '+'){
                    sum += num;
                }
                else if (op == '-'){
                    sum -= num;
                }
            }
            else{
                if(str == "+"){
                    op = '+';
                }
                else if(str == "-"){
                    op = '-';
                }
            }
        }
        answer = sum;
        return answer;
    }
}