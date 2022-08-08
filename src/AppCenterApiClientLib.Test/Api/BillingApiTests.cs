/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using AppCenterApiClientLib.Client;
using AppCenterApiClientLib.Api;
using AppCenterApiClientLib.Model;

namespace AppCenterApiClientLib.Test
{
    /// <summary>
    ///  Class for testing BillingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BillingApiTests
    {
        private BillingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillingApi
            //Assert.IsInstanceOfType(typeof(BillingApi), instance, "instance is a BillingApi");
        }

        /// <summary>
        /// Test BillingAggregatedInformationGetAll
        /// </summary>
        [Test]
        public void BillingAggregatedInformationGetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string period = null;
            //bool? showOriginalPlans = null;
            //var response = instance.BillingAggregatedInformationGetAll(service, period, showOriginalPlans);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        /// <summary>
        /// Test BillingAggregatedInformationGetByApp
        /// </summary>
        [Test]
        public void BillingAggregatedInformationGetByAppTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //string service = null;
            //string period = null;
            //bool? showOriginalPlans = null;
            //var response = instance.BillingAggregatedInformationGetByApp(ownerName, appName, service, period, showOriginalPlans);
            //Assert.IsInstanceOf<InlineResponse20012> (response, "response is InlineResponse20012");
        }
        /// <summary>
        /// Test BillingAggregatedInformationGetForOrg
        /// </summary>
        [Test]
        public void BillingAggregatedInformationGetForOrgTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgName = null;
            //string service = null;
            //string period = null;
            //bool? showOriginalPlans = null;
            //var response = instance.BillingAggregatedInformationGetForOrg(orgName, service, period, showOriginalPlans);
            //Assert.IsInstanceOf<InlineResponse20012> (response, "response is InlineResponse20012");
        }
    }

}
