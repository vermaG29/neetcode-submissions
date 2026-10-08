public class Solution {
    public bool IsAnagram(string s, string t) {
        bool flag = false;
        
        if(s.Length==t.Length)
        {
            char[] sortedstring1 = s.ToCharArray();
            char[] sortedstring2 = t.ToCharArray();
            Array.Sort(sortedstring1);
            Array.Sort(sortedstring2);
            flag = sortedstring1.SequenceEqual(sortedstring2);
            return flag;
        }
        else
        {
            return flag;
        }
    }
}
