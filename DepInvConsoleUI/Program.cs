using SolidUI;

ISentenceGenerator generator = new SpanishSentenceGenerator();
SentenceDisplayer displayer = new SentenceDisplayer(generator);
do
{
    displayer.DisplayNewSentence();
} 
while (Console.ReadKey(true).Key != ConsoleKey.Escape);