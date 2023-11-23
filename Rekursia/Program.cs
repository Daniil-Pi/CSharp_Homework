//
int n=1;
void Str(string a, char[] word, int length = 0)
{

    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}");
         return;
    }
    for (int i = 0; i < a.Length; i++)
    {
        word[length] = a[i];
        Str(a, word, length + 1);
    }
}

Str("аисв", new char[3]);