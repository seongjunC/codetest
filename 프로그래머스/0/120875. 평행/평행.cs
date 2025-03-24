using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        for (int i =0; i<3; i++){
            if(i==0){
                double slo1 = Math.Abs((double)(dots[1,1]-dots[0,1])/(double)(dots[1,0]-dots[0,0]));
                double slo2 = Math.Abs((double)(dots[3,1]-dots[2,1])/(double)(dots[3,0]-dots[2,0])); 
                if(slo1 == slo2){
                    answer = 1;
                    break;
                }
            }
            else if(i ==1){
                double slo1 = Math.Abs((double)(dots[2,1]-dots[0,1])/(double)(dots[2,0]-dots[0,0]));
                double slo2 = Math.Abs((double)(dots[3,1]-dots[1,1])/(double)(dots[3,0]-dots[1,0])); 
                if(slo1 == slo2){
                    answer = 1;
                    break;
                }
            }
            else if(i ==2){
                double slo1 = Math.Abs((double)(dots[3,1]-dots[0,1])/(double)(dots[3,0]-dots[0,0]));
                double slo2 = Math.Abs((double)(dots[1,1]-dots[2,1])/(double)(dots[1,0]-dots[2,0])); 
                if(slo1 == slo2){
                    answer = 1;
                    break;
                }
            }
        }
        return answer;
    }
}