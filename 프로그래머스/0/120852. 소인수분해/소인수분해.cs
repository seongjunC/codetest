using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[1];
        int k = 0;
        bool isLoop = true;
        while(isLoop){
            for (int i = 2; i<=n; i++){
                if( n == i){
                    isLoop = false;
                    if (answer[0] != 0 && answer[answer.Length-1] != i){
                        Array.Resize(ref answer, answer.Length+1);
                        answer[answer.Length-1] = n;
                    }
                    break;
                }
                else if(n%i == 0){
                    n /= i;
                    if(k != 0 && answer[k-1] != i){
                        Array.Resize(ref answer, k+1);
                        answer[k++] = i;
                    }
                    else if(k ==0){
                        Array.Resize(ref answer, k+1);
                        answer[k++] = i;
                    }

                    break;
                }
            }
        }
        if (answer[0] == 0){
            answer[0] = n;
        }
        return answer;
    }
}