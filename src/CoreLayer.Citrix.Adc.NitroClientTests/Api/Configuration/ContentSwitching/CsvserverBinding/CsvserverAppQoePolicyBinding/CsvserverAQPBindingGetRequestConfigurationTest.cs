﻿using System.Collections.Generic;
using System.Collections;
using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding;
using Xunit;

namespace CoreLayer.Citrix.Adc.NitroClientTests.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppQoePolicyBinding
{
    public class CsvserverAQPBindingGetRequestConfigurationTest
    {
        [Theory]
        [ClassData(typeof(CsvserverAQPBindingGetRequestConfigurationValidationTestData))]
        public void CsvserverAQPBindingGetRequestConfigurationValidationTest(
            CsvserverAppQoePolicyBindingGetRequestConfiguration configuration, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ResourcePath"], configuration.ResourcePath);
            Assert.Equal(expected["RequestUri"], configuration.GenerateHttpRequestMessageAsync().Result.RequestUri.ToString());
            Assert.Equal(expected["Method"], configuration.Method.ToString());
            Assert.Equal(expected["Method"], configuration.GenerateHttpRequestMessageAsync().Result.Method.ToString());
            Assert.Equal(expected["Options"], configuration.Options.ToString());
        }
    }

    public class CsvserverAQPBindingGetRequestConfigurationValidationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CsvserverAppQoePolicyBindingGetRequestConfiguration(),
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_appqoepolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_appqoepolicy_binding?bulkbindings=yes"},
                    {"Method", "GET"},
                    {"Options", "?bulkbindings=yes"}
                }
            };
            
            yield return new object[]
            {
                new CsvserverAppQoePolicyBindingGetRequestConfiguration
                {
                    Options = new CsvserverAppQoePolicyBindingGetRequestOptions()
                    {
                        ResourceFilter = new Dictionary<string, string>(),
                        PropertyFilter = new List<string>
                        {
                            "Filter"
                        },
                        ResourceName = "instance1"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_appqoepolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_appqoepolicy_binding/instance1?attrs=Filter"},
                    {"Method", "GET"},
                    {"Options", "/instance1?attrs=Filter"},
                }
            };
            yield return new object[]
            {
                new CsvserverAppQoePolicyBindingGetRequestConfiguration
                {
                    Options = new CsvserverAppQoePolicyBindingGetRequestOptions
                    {
                        PropertyFilter = new List<string>
                        {
                            "Name"
                        },
                        ResourceName = "instance1",
                        Action = "testAction"
                    }
                }, 
                new Dictionary<string, string>
                {
                    {"ResourcePath", "/nitro/v1/config/csvserver_appqoepolicy_binding"},
                    {"RequestUri", "/nitro/v1/config/csvserver_appqoepolicy_binding/instance1?action=testAction"},
                    {"Method", "GET"},
                    {"Options", "/instance1?action=testAction"}
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}