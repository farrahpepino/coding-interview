using System;
using System.Text;

class Program{
    static void Main(string[] args){
        // StringBuilder s = new StringBuilder("Ayah");

        // Console.WriteLine("Before: " + s.Capacity);
        // s.AppendLine("GFG");
        // Console.WriteLine("s: " + s);
        // Console.WriteLine("After GFG: " + s.Capacity);
        // s.AppendLine("GEEKS");
        // Console.WriteLine("s: " + s);
        // Console.WriteLine("After GEEKS: " + s.Capacity);
        // s.Append("GeeksForGeeks");
        // Console.WriteLine("s: " + s);
        // Console.WriteLine("After GeeksForGeeks: " + s.Capacity);
        // s.Replace("Geeks", "FAT");
        // s.Remove(4,9);
        // Console.WriteLine(s);

        string[] names = new string[5];
        names[0] = "Farrah";
        names[1] = "Chris";
        names[2] = "Gia";
        names[3] = "Kath";
        names[4] = "Diane";
        Console.WriteLine(string.Join(", ", names));

        List<string> nameList = new List<string>();
        nameList.Add("Farrah");
        nameList.Add("Chris");
        nameList.Add("Gia");
        nameList.Add("Kath");
        nameList.Add("Diane");
        foreach(string name in nameList){
            Console.WriteLine(name);
        }
        Console.WriteLine(string.Join(", ", nameList));
        nameList.Remove("Diane");
        nameList.Remove("Kath");
        nameList.Remove("Gia");

        Console.WriteLine(string.Join(", ", nameList));



    }
}