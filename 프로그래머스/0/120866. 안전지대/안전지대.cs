using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int[,] isSafe = new int[board.GetLength(0),board.GetLength(1)];
        for(int i = 0; i<board.GetLength(0); i++){
            for (int j = 0; j<board.GetLength(1); j++){
                for(int y = -1; y<=1; y++){
                    for(int x = -1; x<=1; x++){
                        if((i == 0 && y == -1)||(i == board.GetLength(0)-1 && y == 1)){
                             continue;
                         }
                        else if((j==0 && x == -1)||(j==board.GetLength(1)-1 && x == 1)){
                            continue;
                        }
                        if(board[y+i,x+j] == 1){
                            isSafe[i,j] += 1;
                            break;
                        }
                    }
                }
                if(isSafe[i,j] ==0){
                    answer += 1;
                }
            }
        }
        
        return answer;
    }
}