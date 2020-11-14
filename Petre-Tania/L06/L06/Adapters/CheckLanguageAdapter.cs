﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Access.Primitives.Extensions.ObjectExtensions;
using Access.Primitives.IO;
using LanguageExt;
using System.Linq;
using L06.Models;
using L06.Inputs;
using L06.Outputs;
using static LanguageExt.Prelude;

namespace L06.Adapters
{
    class CheckLanguageAdapter : Adapter<CheckLanguageCmd, CheckLanguageResult.ICheckLanguageResult, QuestionWriteContext>
    {
        public override Task PostConditions(CheckLanguageCmd cmd, CheckLanguageResult.ICheckLanguageResult result, QuestionWriteContext state)
        {
            return Task.CompletedTask;
        }
        
        public override async Task<CheckLanguageResult.ICheckLanguageResult> Work(CheckLanguageCmd cmd, QuestionWriteContext state)
        {
            var wf = from isValid in cmd.TryValidate()
                     from checkLanguageResult in CheckLanguage(cmd, state)
                     select checkLanguageResult;
            return await wf.Match(
                  Succ: checklanguage => checklanguage,
                  Fail: ex => new CheckLanguageResult.CheckFailed(ex.ToString()));
        }

        private TryAsync<CheckLanguageResult.ICheckLanguageResult> CheckLanguage(CheckLanguageCmd cmd, QuestionWriteContext state)
        {

            return TryAsync<CheckLanguageResult.ICheckLanguageResult>(async () =>
            {
                return new CheckLanguageResult.TextChecked(50);
            });
        }
    }
}