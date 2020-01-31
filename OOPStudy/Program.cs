using System;

namespace OOPStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunObjectOrientedDesignProgram();
            RunDesignPatternsProgram();
        }

        static void RunObjectOrientedDesignProgram()
        {
            ObjectOrientedCodeDemo.Program.Demo();
        }

        static void RunDesignPatternsProgram()
        {
            Memento.CodeEditor.CodeEditorProgram.Demo();
        }
    }
}
