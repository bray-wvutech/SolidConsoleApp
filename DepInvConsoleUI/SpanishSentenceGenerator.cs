using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidUI;
internal class SpanishSentenceGenerator : ISentenceGenerator
{
    private string[] _subjects = { "Juan", "María", "El gato", "El perro" };
    private string[] _verbs = { "corre", "salta", "duerme", "come" };
    private string[] _adverbs = { "rápidamente", "lentamente", "silenciosamente", "ruidosamente" };

    public string GetNewSentence()
    {
        Random random = new Random();
        string subject = _subjects[random.Next(_subjects.Length)];
        string verb = _verbs[random.Next(_verbs.Length)];
        string adverb = _adverbs[random.Next(_adverbs.Length)];
        return $"{subject} {verb} {adverb}";
    }
}
