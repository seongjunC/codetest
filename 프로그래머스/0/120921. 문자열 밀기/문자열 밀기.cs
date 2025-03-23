using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        int n = 0;
        char a = A[0];
        char[] newA = A.ToCharArray();
        int[] nS = new int[0];
        foreach (char b in B)
        {
            if (a == b)
            {
                Array.Resize(ref nS, nS.Length+1);
                nS[nS.Length-1] = n;
            }
            n++;
        }
        for (int k = 0; k < nS.Length; k++) {
            for (int i = 0; i < A.Length; i++)
            {
                if (i < nS[k])
        {
            newA[i] = A[A.Length - nS[k] + i];
        }
        else
        {
            newA[i] = A[i - nS[k]];
        }
    }
    string strA = "";
    for (int i = 0; i < A.Length; i++)
    {
        strA += newA[i];
    }

    if (strA == B)
    {
        answer = nS[k];
        break;
    }
    else
    {
        answer = -1;
    }
}
        return answer;
    }
}