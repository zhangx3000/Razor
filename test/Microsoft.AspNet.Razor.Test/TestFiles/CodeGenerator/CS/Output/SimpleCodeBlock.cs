#pragma checksum "SimpleCodeBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2564a7b05a63ea402c0407dc760ad8632f5b1dcc"
namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class SimpleCodeBlock
    {
        #line hidden
        public SimpleCodeBlock()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 1 "SimpleCodeBlock.cshtml"
  
    var a = 1;

#line default
#line hidden

            Instrumentation.BeginContext(26, 1, false);
#line 2 "SimpleCodeBlock.cshtml"
               Write(a);

#line default
#line hidden
            Instrumentation.EndContext();
            Instrumentation.BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            Instrumentation.EndContext();
#line 3 "SimpleCodeBlock.cshtml"

#line default
#line hidden

            Instrumentation.BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            Instrumentation.EndContext();
        }
        #pragma warning restore 1998
    }
}
