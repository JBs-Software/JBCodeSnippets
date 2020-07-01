using System;
using IniFileParser;

namespace Program
{
    class Main
    {
        private void Main()
        {
            var Myini = new IniFile("C:/settings.ini");

            Myini.Write("Address", "google.com");

            var address = Myini.Read("Address");

            Console.Writelin(address);
        }
    }
}