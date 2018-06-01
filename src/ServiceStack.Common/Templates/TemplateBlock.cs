﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace ServiceStack.Templates
{
    public abstract class TemplateBlock
    {
        public TemplateContext Context { get; set; }
        public ITemplatePages Pages { get; set; }
        public abstract string Name { get; }
        
        protected virtual string GetCallTrace(PageBlockFragment fragment) => "Block: " + Name + 
           (fragment.Argument.IsNullOrEmpty() ? "" : " (" + fragment.Argument + ")");

        protected virtual string GetElseCallTrace(PageElseBlock fragment) => "Block: " + Name + " > Else" + 
           (fragment.Argument.IsNullOrEmpty() ? "" : " (" + fragment.Argument + ")");

        public abstract Task WriteAsync(TemplateScopeContext scope, PageBlockFragment fragment, CancellationToken cancel);

        protected virtual async Task WriteAsync(TemplateScopeContext scope, PageFragment[] body, string callTrace, CancellationToken cancel)
        {
            await scope.PageResult.WriteFragmentsAsync(scope, body, callTrace, cancel);
        }

        protected virtual async Task WriteBodyAsync(TemplateScopeContext scope, PageBlockFragment fragment, CancellationToken token)
        {
            await WriteAsync(scope, fragment.Body, GetCallTrace(fragment), token);
        }

        protected virtual async Task WriteElseAsync(TemplateScopeContext scope, PageElseBlock fragment, CancellationToken token)
        {
            await WriteAsync(scope, fragment.Body, GetElseCallTrace(fragment), token);
        }

        protected async Task WriteElseBlocks(TemplateScopeContext scope, PageElseBlock[] elseBlocks, CancellationToken cancel)
        {
            foreach (var elseBlock in elseBlocks)
            {
                if (elseBlock.Argument.IsNullOrEmpty())
                {
                    await WriteElseAsync(scope, elseBlock, cancel);
                    return;
                }

                var argument = elseBlock.Argument;
                if (argument.StartsWith("if "))
                    argument = argument.Advance(3);

                var result = argument.GetJsExpressionAndEvaluateToBool(scope,
                    ifNone: () => throw new NotSupportedException("'else if' block does not have a valid expression"));
                if (result)
                {
                    await WriteElseAsync(scope, elseBlock, cancel);
                    return;
                }
            }
        }
    }
}