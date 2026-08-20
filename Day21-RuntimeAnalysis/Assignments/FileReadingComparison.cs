using System.IO;

class FileReadingComparison
{
    public static int ReadWithStreamReader(string path)
    {
        int count=0;

        using(StreamReader sr=new StreamReader(path))
        {
            while(sr.Read()!=-1)
            {
                count++;
            }
        }

        return count;
    }

    public static int ReadWithFileStream(string path)
    {
        int count=0;

        using(FileStream fs=new FileStream(path,FileMode.Open))
        {
            byte[] buffer=new byte[4096];
            int bytes;

            while((bytes=fs.Read(buffer,0,buffer.Length))>0)
            {
                count+=bytes;
            }
        }

        return count;
    }
}