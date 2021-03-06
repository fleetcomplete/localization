﻿using System;
using CommandLine;
using CommandLine.Text;


namespace ResxClassGenerator
{
    public class GenArgs
    {
        [Option("resx", Required = true, HelpText = "RESX file to parse")]
        public string ResxFilePath { get; set; }

        [Option("class", Required = true, HelpText = "Name of the class")]
        public string Class { get; set; }

        [Option("namespace", Required = true, HelpText = "Namespace of the class")]
        public string Namespace { get; set; }


        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
