class Program{
    static void Main(string[] args){
        string name="Farrah";
        Console.WriteLine(name);
        char[] charName = name.ToCharArray();

        for(int i=0, j=name.Length-1; i<j; i++, j--){
            charName[i]=name[j];
            charName[j]=name[i];
        }

        string reversedString = new string(charName);
        Console.WriteLine(reversedString);
    }
}
