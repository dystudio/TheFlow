﻿using TheFlow.CoreConcepts;
using TheFlow.Elements.Activities;

namespace TheFlow.Tests.Functional.PickingProducts
{
    public class PickStockActivity : Activity
    {
        public override void Run(ExecutionContext context)
        {
            context.Instance.HandleActivityCompletion(context, null);
        }
    }
}