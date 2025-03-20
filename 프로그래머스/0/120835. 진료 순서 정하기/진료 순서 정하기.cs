using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        int[] sortedEmer = new int[emergency.Length];
        int k=0;
        foreach(int i in emergency){
            sortedEmer[k++] = i;
        }
        Array.Sort(sortedEmer, (a,b) => a>b ? -1 : 1);
        k = 1;
        int now = 0;
        foreach(int i in emergency){
            foreach(int j in  sortedEmer){
                if(i == j){
                    answer[now++] = k;
                    k = 1;
                    break;
                }
                k++;
                
            }
        }
        return answer;
    }
}