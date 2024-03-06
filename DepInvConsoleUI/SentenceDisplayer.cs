using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidUI;
internal class SentenceDisplayer
{
    private ISentenceGenerator _generator;

    public SentenceDisplayer(ISentenceGenerator generator)
    {
        _generator = generator;
    }

    public void DisplayNewSentence()
    {
        string sentence = _generator.GetNewSentence();
        Console.WriteLine(sentence);
    }
}
