using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      byte[] pdrId = BitConverter.GetBytes((UInt32)1710003000);  //1710003000
      Console.WriteLine(pdrId[0].ToString());
      Console.WriteLine(pdrId[0].ToString("X2"));
      Console.ReadKey();
    }
  }
}
