﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Memory;

namespace Enigma.D3.Collections
{
	public class ListPack : ListPack<MemoryObject>
	{
		public ListPack(ProcessMemory memory, int address)
			: base(memory, address) { }
	}


	public class ListPack<T> : MemoryObject
	{
		// 2.0.1.22044
		public const int SizeOf = 0x14; // 20

		public ListPack(ProcessMemory memory, int address)
			: base(memory, address) { }

		public LinkedList<T> x00_List { get { return Field<LinkedList<T>>(0x00); } }
		public Allocator x10_ListNodeAllocator { get { return Field<Allocator>(0x10); } }
		public int x2C_Boolean { get { return Field<int>(0x2C); } }

		public override string ToString()
		{
			if (x10_ListNodeAllocator.x18_GoodFood != 0x600DF00D)
			{
				return base.ToString() + " { Valid: False }";
			}
			else
			{
				return base.ToString() + " { " + string.Join(", ",
					"Valid: True",
					"ItemSize: " + (x10_ListNodeAllocator.x00_ElementSize - 8),
					"Count: " + x00_List.x08_Count) + "}";
			}
		}
	}
}
