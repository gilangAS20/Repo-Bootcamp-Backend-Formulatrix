using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
// in file "Method_CustomFooBar.cs"
namespace CustomFooBar
{
    public class Operation
    {
        private static SortedDictionary<int, string> dictList = new SortedDictionary<int, string>();

        public bool tryAdd(int angka, string karakter)
        {
            if (dictList.ContainsKey(angka))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public (string, bool) AddKeyValue(int angka, string karakter)
        {   
            StringBuilder result = new();
            result.Append("Add dictionary with Key: " + angka + ", Value: " + karakter);
            bool success;
            
            tryAdd(angka, karakter);
            if (tryAdd(angka, karakter) == true)
            {
                dictList[angka] = karakter;
                success = true;
            }
            else
            {
                result.Clear();
                result.Append($"Cannot add Key '{angka}' exist");
                success = false;
            }

            return (result.ToString(), success);
        }

        public string DisplayDict()
        {
            StringBuilder result = new();
            result.Append("\nDisplay Dictionary: \n");
            foreach(var kvp in dictList)
            {
                result.Append("Key: " + kvp.Key + ", Value: " + kvp.Value + "\n");
            }
            return result.ToString();
        }

        public (string, bool) RemoveDict(int key)
        {
            StringBuilder result = new();
            result.Append($"Remove dictionary with Key: {key} \nResult after remove:\n");
            bool successRemove = false;

                if(dictList.ContainsKey(key))
                {
                    dictList.Remove(key);
                    foreach(var kvp in dictList)
                    {
                        result.Append("Key: " + kvp.Key + ", Value: " + kvp.Value + "\n");
                        successRemove = true;
                    }
                }
                else
                {
                    result.Clear();
                    result.Append($"Cannot remove, Key {key} not found");
                    successRemove = false;
                }
            return (result.ToString(), successRemove);
        }

        public string DisplayChange(int input)
        {   
            StringBuilder result = new();
            for(int i = 0; i <= input; i++)
            {
                StringBuilder sb_temporary = new();
                sb_temporary.Append("");
                if(i == 0)
                {
                    sb_temporary.Append(i);
                }
                else
                {
                    foreach(var kvp in dictList.Keys)
                    {
                        if(i % kvp == 0)
                        {
                            sb_temporary.Append(dictList[kvp]);
                        }
                    }
                    if(sb_temporary.Equals(""))
                    {
                        sb_temporary.Append(i);
                    }
                }
                result.Append(" " + sb_temporary);
            }
            result.Append("\n");
            return result.ToString();
        }
    } // public class Operation
}