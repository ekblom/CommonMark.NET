﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonMark.Tests
{
    [TestClass]
    public class HtmlTests
    {
        [TestMethod]
        [TestCategory("Inlines - Raw HTML")]
        public void HtmlTagsWithDigits()
        {
            Helpers.ExecuteTest("foo <h1>asd</h1> bar", "<p>foo <h1>asd</h1> bar</p>");
        }

        /// <summary>
        /// Tests HTML block tag names of various lengths (see https://github.com/Knagis/CommonMark.NET/issues/16)
        /// </summary>
        [TestMethod]
        [TestCategory("Leaf blocks - HTML blocks")]
        public void HtmlTagNameLengths()
        {
            var source = "";
            var result = "";
            foreach (var tag in new[] { "p", "h1", "map", "form", "style", "object", "section", "progress", "progress2", "blockquote", "blockquoteX" })
            {
                source += "<" + tag + ">\n\t*" + tag + "*\n</" + tag + ">\n\n";
                if (tag == "progress2" || tag == "blockquoteX")
                    result += "<p><" + tag + ">\n<em>" + tag + "</em>\n</" + tag + "></p>\n";
                else
                    result += "<" + tag + ">\n    *" + tag + "*\n</" + tag + ">\n";
            }

            Helpers.ExecuteTest(source, result);
        }
    }
}
