﻿using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsLimitIdentifier;
using Xunit;


namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Statistics.Ns.NsLimitIdentifier
{
    public class NsLimitIdentifierStatRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(NsLimitIdentifierStatRequestConfigurationValidationTestData))]
        public void NsLimitIdentifierStatRequestConfigurationValidationTest(
            NsLimitIdentifierStatRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class NsLimitIdentifierStatRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NsLimitIdentifierStatRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/nslimitidentifier"},
                    {"Method", "GET"},
                    {"Options", ""},
                    {"RequestUri", "/nitro/v1/stat/nslimitidentifier"}
                } 
            };
            yield return new object[]
            {
                new NsLimitIdentifierStatRequestConfiguration
                {
                    Options = new NsLimitIdentifierStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "wrongFilter"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/nslimitidentifier"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=wrongFilter"},
                    {"RequestUri", "/nitro/v1/stat/nslimitidentifier/resourceName?attrs=wrongFilter"}
                } 
            };
            yield return new object[]
            {
                new NsLimitIdentifierStatRequestConfiguration
                {
                    Options = new NsLimitIdentifierStatRequestOptions
                    {
                        ResourceName = "resourceName",
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        }
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/stat/nslimitidentifier"},
                    {"Method", "GET"},
                    {"Options", "/resourceName?attrs=Name"},
                    {"RequestUri", "/nitro/v1/stat/nslimitidentifier/resourceName?attrs=Name"}
                } 
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}