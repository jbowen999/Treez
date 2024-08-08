﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treez
{
    public class Node<T>(T d)
    {
        public T Data => d;
        public Node<T>? Left;
        public Node<T>? Right;
    }
}
