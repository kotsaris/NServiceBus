﻿namespace NServiceBus.IntegrationTests.Support
{
    using System;
    using System.Collections.Generic;
    using NServiceBus.Config;

    public class EndpointBehavior
    {
        public string EndpointName { get; set; }

        public List<Action<IBus>> Givens { get; set; }

        public MessageEndpointMappingCollection EndpointMappings { get; set; }

        public Func<BehaviorContext, bool> Done { get; set; }

        public List<Action<IBus>> Whens { get; set; }

        public List<Action<IDictionary<string, string>, Configure>> Setups { get; set; }
    }
}