﻿namespace Ocelot.AcceptanceTests
{
    public static class TestConfiguration
    {
        public static double Version => 1.4;
        public static string ConfigurationPath => $"./bin/Debug/netcoreapp{Version}/configuration.json";
    }
}
