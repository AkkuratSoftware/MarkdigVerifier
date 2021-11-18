using Markdig;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarkdigVerifier
{
    public static class MarkdownConverter
    {
        public static string Parse(string markdown)
        {
            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .Build();
            return Markdown.ToHtml(markdown, pipeline);
        }
    }
}
