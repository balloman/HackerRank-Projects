using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    class SockCount {
        public int Id { get; set; }
        public int Count { get; set; }

        public SockCount(int id)
        {
            Count = 1;
            Id = id;
        }

        public void Increment()
        {
            Count += 1;
        }
    }

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        List<SockCount> socks = new List<SockCount>();
        foreach (int element in ar)
        {
            bool exists = false;
            foreach (SockCount sock in socks){
                if (sock.Id == element)
                {
                    sock.Increment();
                    exists = true;
                }
            }
            
            if (!exists)
            {
                SockCount sock = new SockCount(element);
                socks.Add(sock);
            }
        }

        int pairs = 0;
        foreach (var variable in socks)
        {
            pairs += (int) Math.Truncate((double) (variable.Count / 2));
        }

        return pairs;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(sockMerchant(9, new[] {10, 20, 10}));
    }
}
