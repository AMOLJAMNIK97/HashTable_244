using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K Key)
        {
            int position = Key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K Key)
        {
            int position=GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedKList(position);
            foreach (KeyValue<K,V> item in linkedlist)
            {
                if (item.key.Equals(Key))
                {
                    return item.value;
                }
            }
            return default;
        }
        public void Add(K Key, V Value)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedKList(position);
            KeyValue<K, V> item = new KeyValue<K, V> { key = Key, value = Value };
            linkedlist.AddLast(item);
        }
        public void Remove(K Key)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedKList(position);
            bool itemFound=false;
            KeyValue<K, V> Founditem = default(KeyValue<K, V>);
            foreach(KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(Key))
                {
                    itemFound = true;
                    Founditem = item;
                }

            }
            if (itemFound)
            {
                linkedList.Remove(Founditem);
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedKList(int position)
        {
            LinkedList<KeyValue<K,V>> linkedlist=items[position];
            if(linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[position]=linkedlist;
            }
            return linkedlist;

        }
    }
    public struct KeyValue<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }
    }
}
