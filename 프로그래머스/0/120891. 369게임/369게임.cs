using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        string strOrder = order.ToString();
        foreach(char cha in strOrder){
            if(cha == '3'){
                answer+=1;
            }
            else if(cha == '6'){
                answer +=1;
            }
            else if(cha == '9'){
                answer +=1;
            }
        }
        return answer;
    }
}