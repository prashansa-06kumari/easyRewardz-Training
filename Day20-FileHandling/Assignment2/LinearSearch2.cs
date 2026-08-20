class LinearSearch2
{
    public static int FindWord(string[] sentences,string word)
    {
        for(int i=0;i<sentences.Length;i++)
        {
            if(sentences[i].Contains(word))
                return i;
        }

        return -1;
    }
}