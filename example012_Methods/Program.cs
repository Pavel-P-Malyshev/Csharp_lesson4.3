/*Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.*/


string Replace(string text, char oldval, char newval)
{
    string result=String.Empty;
    int length=text.Length;
    for(int i=0;i<length;i++)
    {
        if (text[i]==oldval) {result+=$"{newval}";}
        else {result+=$"{text[i]}";}
    }
    

    return result;
}


string story="— Я думаю, — сказал князь, улыбаясь, — что," 
+" ежели бы вас послали вместо нашего милого "
+"Винценгероде, вы бы взяли приступом согласие"
+" прусского короля. Вы так красноречивы. Вы"
+" дадите мне чаю";

string NewStory=Replace(story,' ','_');
System.Console.WriteLine();
System.Console.WriteLine(NewStory);
System.Console.WriteLine();
NewStory=Replace(story,'к','К');
System.Console.WriteLine(NewStory);
System.Console.WriteLine();
NewStory=Replace(story,'С','с');
System.Console.WriteLine(NewStory);
System.Console.WriteLine();



