using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Algorithms
{
    public class HashTable
    {
        // Add Method 
        static public void Add()
        {

            // Create a hashtable 
            // Using Hashtable class 
            Hashtable my_hashtable1 = new Hashtable();

            // Adding key/value pair  
            // in the hashtable 
            // Using Add() method 
            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "GeeksforGeeks");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }

            // Create another hashtable 
            // Using Hashtable class 
            // and adding key/value pairs 
            // without using Add method 
            Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Keys)
            {
                Console.WriteLine("{0}and {1}", ele2,
                                my_hashtable2[ele2]);
            }
        }

        // Remove Method 
        static public void Remove()
        {

            // Create a hashtable 
            // Using Hashtable class 
            Hashtable my_hashtable = new Hashtable();

            // Adding key/value pair 
            // in the hashtable 
            // Using Add() method 
            my_hashtable.Add("A1", "Welcome");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add("A3", "GeeksforGeeks");

            // Using remove method 
            // remove A2 key/value pair 
            my_hashtable.Remove("A2");

            Console.WriteLine("Key and Value pairs :");

            foreach (DictionaryEntry ele1 in my_hashtable)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }

            // Before using Clear method 
            Console.WriteLine("Total number of elements present" +
                     " in my_hashtable:{0}", my_hashtable.Count);

            my_hashtable.Clear();

            // After using Clear method 
            Console.WriteLine("Total number of elements present in" +
                           " my_hashtable:{0}", my_hashtable.Count);
        }
        // check the availability of key/value pair in hashtable Method 
        static public void CheckKeyValuePair()
        {

            // Create a hashtable 
            // Using Hashtable class 
            Hashtable my_hashtable = new Hashtable();

            // Adding key/value pair in the hashtable 
            // Using Add() method 
            my_hashtable.Add("A1", "Welcome");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add("A3", "GeeksforGeeks");

            // Determine whether the given 
            // key present or not 
            // using Contains method 
            Console.WriteLine(my_hashtable.Contains("A3"));
            Console.WriteLine(my_hashtable.Contains(12));
            Console.WriteLine();

            // Determine whether the given 
            // key present or not 
            // using ContainsKey method 
            Console.WriteLine(my_hashtable.ContainsKey("A1"));
            Console.WriteLine(my_hashtable.ContainsKey(1));
            Console.WriteLine();

            // Determine whether the given 
            // value present or not 
            // using ContainsValue method 
            Console.WriteLine(my_hashtable.ContainsValue("geeks"));
            Console.WriteLine(my_hashtable.ContainsValue("to"));
        }
        public void run()
        {
            Add();
            Remove();
            CheckKeyValuePair();
            Console.ReadLine();
        }
    }
}
