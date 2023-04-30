using ConsoleApp9.Models;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;

Builders sb = new Builders();
sb.CustomBuilder();
sb.Append('h');
sb.Append('e');
sb.Append('l');
sb.Append('l');
sb.Append('o');
sb.Append('w');
sb.Append('o');
sb.Append('r');
sb.Append('l');
sb.Append('d');
sb.ReplaceChar('w', 'r');
sb.RemoveIndex(4, 1);
Console.WriteLine(sb.GetResult());



