﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T>
    {
        Element<T> head;
        public List()
        {
            head = null;
        }
        public void themDau(Element<T> e)
        {
            e.Next = head;
            this.head = e;
        }
        public void printList()
        {
            Element<T> pointer = head;
            while (pointer != null)
            {
                Console.Write(pointer.Data + " ");
                pointer = pointer.Next;
            }
        }
    }
}
