string hello = "hello, world! Here I am!";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

int wordCounter = 1;

for(int i = 0; i < hello.Length; i++)
{
    if (hello[i] == ' ')
    {
        wordCounter++;
    }
}

Console.WriteLine($"Word count in {hello}: {wordCounter} words.");