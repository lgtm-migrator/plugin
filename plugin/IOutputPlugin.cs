﻿using Newtonsoft.Json.Linq;

namespace plugin
{
    public interface IOutputPlugin
    {
        void Execute(string jsonData, JObject settings);
    }
}