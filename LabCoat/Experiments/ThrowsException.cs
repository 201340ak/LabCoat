﻿using System;

namespace Sandbox.Experiments
{
    internal class ThrowsException : IExperiment
    {
        public void Experiment()
        {
            throw new FieldAccessException("hello");
        }

        public string IdentifyExperiment()
        {
            return typeof(ThrowsException).Name;
        }
    }
}