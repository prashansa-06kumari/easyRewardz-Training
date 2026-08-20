using System.Text.RegularExpressions;
using System.Globalization;

public class Transaction
{
    public string CardNo{get;set;}
    public string Mcc{get;set;}
    public decimal Amount{get;set;}
    public DateTime Time{get;set;}

    public DateTime Hour
    {
        get
        {
            return new DateTime(
                Time.Year,
                Time.Month,
                Time.Day,
                Time.Hour,
                0,
                0
            );
        }
    }
}

public class TransactionStore<T> where T:Transaction
{
    public List<T> Transactions=new List<T>();
    public Dictionary<string,List<T>> CardIndex=new Dictionary<string,List<T>>();
    public Dictionary<DateTime,List<T>> HourIndex=new Dictionary<DateTime,List<T>>();

    public void Add(T txn)
    {
        Transactions.Add(txn);

        if(!CardIndex.ContainsKey(txn.CardNo))
        {
            CardIndex[txn.CardNo]=new List<T>();
        }

        CardIndex[txn.CardNo].Add(txn);

        if(!HourIndex.ContainsKey(txn.Hour))
        {
            HourIndex[txn.Hour]=new List<T>();
        }

        HourIndex[txn.Hour].Add(txn);
    }
}

public class Program
{
    static void Main()
    {
        TransactionStore<Transaction> store=new TransactionStore<Transaction>();

        string[] logs=
        {
            "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50 | TS:2026-08-14T13:01:00",
            "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:300.00 | TS:2026-08-14T13:03:00",
            "CARD:4532-XXXX-XXXX-1129 | MCC:5812 | AMT:150.00 | TS:2026-08-14T13:06:00",
            "CARD:5678-XXXX-XXXX-9999 | MCC:5812 | AMT:100.00 | TS:2026-08-14T14:10:00",
            "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:250.00"
        };

        foreach(string log in logs)
        {
            Transaction txn;

            if(ParseTransaction(log,out txn))
            {
                store.Add(txn);
            }
            else
            {
                Console.WriteLine("Invalid transaction rejected.");
            }
        }

        List<string> suspiciousCards=FindSuspiciousCards(store.Transactions);

        Console.WriteLine("\nSuspicious Cards:");

        foreach(string card in suspiciousCards)
        {
            Console.WriteLine(card);
        }

        Console.WriteLine("\nMCC Statistics:");

        var mccGroups=store.Transactions.GroupBy(t=>t.Mcc);

        foreach(var group in mccGroups)
        {
            decimal total=group.Sum(t=>t.Amount);
            decimal average=group.Average(t=>t.Amount);
            int count=group.Count();

            Console.WriteLine("MCC: "+group.Key);
            Console.WriteLine("Total Spend: "+total);
            Console.WriteLine("Average Transaction: "+average);
            Console.WriteLine("Transaction Count: "+count);
            Console.WriteLine();
        }

        Console.WriteLine("Hourly Transactions:");

        var hourGroups=store.Transactions.GroupBy(t=>t.Hour);

        foreach(var group in hourGroups)
        {
            Console.WriteLine(
                group.Key+" -> "+group.Count()+" transactions"
            );
        }
    }

    public static bool ParseTransaction(string log,out Transaction txn)
    {
        txn=null;

        string pattern=@"^CARD:(?<card>\d{4}-XXXX-XXXX-\d{4}) \| MCC:(?<mcc>\d{4}) \| AMT:(?<amount>\d+\.\d{2}) \| TS:(?<time>\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2})$";

        Match match=Regex.Match(log,pattern);

        if(!match.Success)
        {
            return false;
        }

        string card=match.Groups["card"].Value;
        string mcc=match.Groups["mcc"].Value;
        string amountText=match.Groups["amount"].Value;
        string timeText=match.Groups["time"].Value;

        if(!decimal.TryParse(amountText,out decimal amount))
        {
            return false;
        }

        if(!DateTime.TryParse(timeText,out DateTime time))
        {
            return false;
        }

        txn=new Transaction
        {
            CardNo=card,
            Mcc=mcc,
            Amount=amount,
            Time=time
        };

        return true;
    }

    public static List<string> FindSuspiciousCards(List<Transaction> transactions)
    {
        List<string> suspiciousCards=new List<string>();

        var cardGroups=transactions.GroupBy(t=>t.CardNo);

        foreach(var group in cardGroups)
        {
            List<Transaction> sortedTxns=group.OrderBy(t=>t.Time).ToList();

            bool isSuspicious=false;

            for(int i=0;i<sortedTxns.Count;i++)
            {
                DateTime windowStart=sortedTxns[i].Time;
                DateTime windowEnd=windowStart.AddMinutes(10);

                int count=0;

                foreach(var txn in sortedTxns)
                {
                    if(txn.Time>=windowStart && txn.Time<=windowEnd)
                    {
                        count++;
                    }
                }

                if(count>3)
                {
                    isSuspicious=true;
                    break;
                }
            }

            if(isSuspicious)
            {
                suspiciousCards.Add(group.Key);
            }
        }

        return suspiciousCards;
    }
}