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
