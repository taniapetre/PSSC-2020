﻿using Access.Primitives.Extensions.ObjectExtensions;
using Access.Primitives.IO;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using L06.Inputs;
using L06.Outputs;
using static LanguageExt.Prelude;

namespace L06.Adapters
{
    class SenAckToQuestionOwnerAdapter : Adapter<SendAckToQuestionOwnerCmd, SendAckToQuestionOwnerResult.ISendAckToQuestionOwnerResult, Unit>
    {
        public override Task PostConditions(SendAckToQuestionOwnerCmd cmd, SendAckToQuestionOwnerResult.ISendAckToQuestionOwnerResult result, Unit state)
        {
            return Task.CompletedTask;
        }

        public override async Task<SendAckToQuestionOwnerResult.ISendAckToQuestionOwnerResult> Work(SendAckToQuestionOwnerCmd cmd, Unit state)
        {
            var wf = from isValid in cmd.TryValidate()
                     from ownerAck in OwnerAckResult(cmd, state)
                     select ownerAck;
            return await wf.Match(
                  Succ: owner => owner,
                  Fail: ex => new SendAckToQuestionOwnerResult.InvalidReplyReceived(ex.ToString()));
        }
        private TryAsync<SendAckToQuestionOwnerResult.ISendAckToQuestionOwnerResult> OwnerAckResult(SendAckToQuestionOwnerCmd cmd, Unit state)
        {

            return TryAsync<SendAckToQuestionOwnerResult.ISendAckToQuestionOwnerResult>(async () =>
            {
                return new SendAckToQuestionOwnerResult.ReplyReceived(cmd.Text);
            });
        }
    }
}
