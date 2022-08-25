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

namespace HackerRankSolutions
{
    public class ReverseArray
    {
        public static List<int> reverseArray(List<int> a)
        {
            if (a == null || a.Count < 2) return a;
            for(int i = 0; i < a.Count / 2; i++)
            {
                int temp = a[i];
                a[i] = a[a.Count - (i + 1)];
                a[a.Count - (i + 1)] = temp;
            }
            return a;
        }

    }
}
