using System;

public class Solution {
    public string[] solution(string[] quiz) {
            string[] answer = new string[quiz.GetLength(0)] ;
            string op = "";
            int now = 0;
            int k = 0;
            foreach (string quizs in quiz)
            {
                int[] nums = new int[3] { -20000, -20000, -20000 };
                string[] x = quizs.Split(' ');
                foreach (string y in x)
                {
                    string ycopy = y;
                    if (y == "-" || y == "+")
                    {
                        op = ycopy;
                    }
                    else if(y == "=")
                    {
                        continue;
                    }
                    else if (int.TryParse(ycopy, out now))
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (nums[i] <= -20000)
                            {
                                nums[i] = now;
                                break;
                            }
                        }
                    }
                    else
                    {
                        char[] yArr = y.ToCharArray();
                        string nowArr = "";
                        for (int j = 1; j<yArr.Length; j++)
                        {
                            nowArr += yArr;
                        }
                        now = int.Parse(nowArr);
                        for (int i = 0; i < 3; i++)
                        {
                            if (nums[i] <= -20000)
                            {
                                nums[i] = -now;
                                break;
                            }
                        }
                    }
                }
                switch (op)
                {
                    case "+":
                        if (nums[0] + nums[1] == nums[2])
                        {
                            answer[k++] = "O";
                        }
                        else
                        {
                            answer[k++] = "X";
                        }
                        continue;
                    case "-":
                        if (nums[0] - nums[1] == nums[2])
                        {
                            answer[k++] = "O";
                        }
                        else
                        {
                            answer[k++] = "X";
                        }
                        continue;
                }
            }
        return answer;
    }
}