using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HashTable
{
    public class HashTable
    {
        public string[] _hashTable { get; set; }
        
        public HashTable()
        {
            _hashTable = new string[10];
        }
        //This as VERY VERY weak hashing algorithm
        private int _hash(string key)
        {
            return key.Length % _hashTable.Length;
        }
        public string Get(string key)
        {
            int hashedKey = _hash(key);
            return _hashTable[hashedKey];
        }
        public void Set(string key, string value)
        {
            //Key is going to be bashed
            int hashedKey = _hash(key);

            if (_hashTable[hashedKey] != null)
            {
                Console.WriteLine("Sorry, hash collision has occured");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }
    }
}
