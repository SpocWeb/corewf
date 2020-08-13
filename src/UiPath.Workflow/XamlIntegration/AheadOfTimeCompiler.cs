﻿using System.Collections.Generic;
using System.Reflection;

namespace System.Activities.XamlIntegration
{
    public abstract class AheadOfTimeCompiler
    {
        public abstract TextExpressionCompilerResults Compile(ClassToCompile classToCompile);
    }
    public class ClassToCompile
    {
        public ClassToCompile(string className, string code, IReadOnlyCollection<Assembly> references, IReadOnlyCollection<string> imports)
        {
            ClassName = className;
            Code = code;
            References = references;
            Imports = imports;
        }
        public string Code { get; }
        public IReadOnlyCollection<Assembly> References { get; set; }
        public IReadOnlyCollection<string> Imports { get; }
        public string ClassName { get; }
        public override string ToString() => Code;
    }
}