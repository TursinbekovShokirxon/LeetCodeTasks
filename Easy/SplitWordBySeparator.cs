namespace LeetCodeTasks.Easy
{
    public class SplitWordBySeparator
    {
        public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            IList<string> newStr = new List<string>();
            for (int i = 0; i < words.Count(); i++)
            {
                foreach (var item in words[i].Split(separator))
                {
                    if (item != "") newStr.Add(item);
                }
            }
            return newStr;
        }
    }
}
