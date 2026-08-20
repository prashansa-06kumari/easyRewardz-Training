using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ConsoleApprev3.Tests
{
    public class FraudTests
    {
        [Test]
        public void ValidTransaction()
        {
            string log="CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50 | TS:2026-08-14T13:22:05";

            Transaction txn;

            bool result=Program.ParseTransaction(log,out txn);

            Assert.That(result,Is.True);
            Assert.That(txn.CardNo,Is.EqualTo("4532-XXXX-XXXX-1129"));
            Assert.That(txn.Mcc,Is.EqualTo("5411"));
            Assert.That(txn.Amount,Is.EqualTo(245.50m));
        }

        [Test]
        public void InvalidTransaction()
        {
            string log="CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50";

            Transaction txn;

            Assert.That(
                Program.ParseTransaction(log,out txn),
                Is.False
            );
        }

        [Test]
        public void FraudDetection()
        {
            var txns=new List<Transaction>
            {
                new Transaction
                {
                    CardNo="4532-XXXX-XXXX-1129",
                    Time=new DateTime(2026,8,14,13,1,0)
                },

                new Transaction
                {
                    CardNo="4532-XXXX-XXXX-1129",
                    Time=new DateTime(2026,8,14,13,3,0)
                },

                new Transaction
                {
                    CardNo="4532-XXXX-XXXX-1129",
                    Time=new DateTime(2026,8,14,13,6,0)
                },

                new Transaction
                {
                    CardNo="4532-XXXX-XXXX-1129",
                    Time=new DateTime(2026,8,14,13,9,0)
                }
            };

            var result=Program.FindSuspiciousCards(txns);

            Assert.That(
                result,
                Does.Contain("4532-XXXX-XXXX-1129")
            );
        }

        [Test]
        public void HourlyBucket()
        {
            var txn=new Transaction
            {
                Time=new DateTime(2026,8,14,13,22,5)
            };

            Assert.That(
                txn.Hour,
                Is.EqualTo(new DateTime(2026,8,14,13,0,0))
            );
        }
    }
}