// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter character");
char ch = (Convert.ToChar(Console.ReadLine()));


    if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
    {
        switch(ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U': Console.WriteLine("Vowel"); break;

            default: Console.WriteLine("consonant"); break;
        }
     
    }

    else
    {
        Console.WriteLine("not an alphabet");
    }

    
