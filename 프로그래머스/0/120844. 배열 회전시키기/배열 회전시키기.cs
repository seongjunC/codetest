using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        int k = 0;
        if(direction == "right"){
            foreach(int i in numbers){
                if( k == numbers.Length-1){
                    answer[0] = i;
                }
                else {
                    answer[k+1] = i;
                    k++;
                }
            }
        }
        else if(direction == "left"){
            foreach(int i in numbers){
                if(k == 0){
                    answer[numbers.Length-1] = i;
                    k++;
                }
                else{
                    answer[k-1] = i;
                    k++;
                }
            }
        }

        return answer;
    }
}