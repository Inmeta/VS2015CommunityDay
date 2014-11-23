using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests.d12_Memory
{
    public class Memory
    {
        List<string> Lines { get; set; }
        public void Load()
        {
            var d = Directory.GetCurrentDirectory();
            var p = (Path.Combine(d, @"..\..\d12-Memory\memory.cs"));
            var lines = File.ReadAllLines(p);
            Lines = new List<string>();
            Lines.AddRange(lines);
        }
    }

    [Explicit]
    [Memory]
    [TestFixture]
    public class TestMemory
    {
        [Test]
        public void InMemoryLand()
        {
            var list = new List<Memory>();
            for (int i=0;i<100000;i++)
            {
                var sut = new Memory();
                sut.Load();
                list.Add(sut);
            }

        }
    }


    public class MemoryAttribute : CategoryAttribute
        {}

}
