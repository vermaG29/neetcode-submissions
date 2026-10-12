public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> checkAnagram = new Dictionary<string, List<string>>();
        foreach (string str in strs) {
            //char[] arr = str.ToCharArray();
            //Array.Sort(arr);
            string word = new string(str.OrderBy(c=>c).ToArray());
            if (!checkAnagram.ContainsKey(word)) {
                checkAnagram[word] = new List<string>();
            }
            checkAnagram[word].Add(str);
        }
        return checkAnagram.Values.ToList();
    }
}