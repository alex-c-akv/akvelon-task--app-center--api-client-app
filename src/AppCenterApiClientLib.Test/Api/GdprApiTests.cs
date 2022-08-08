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
    ///  Class for testing GdprApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GdprApiTests
    {
        private GdprApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GdprApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GdprApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GdprApi
            //Assert.IsInstanceOfType(typeof(GdprApi), instance, "instance is a GdprApi");
        }

        /// <summary>
        /// Test DataSubjectRightCancelDeleteRequest
        /// </summary>
        [Test]
        public void DataSubjectRightCancelDeleteRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? token = null;
            //TokenCancelBody body = null;
            //var response = instance.DataSubjectRightCancelDeleteRequest(token, body);
            //Assert.IsInstanceOf<InlineResponse202> (response, "response is InlineResponse202");
        }
        /// <summary>
        /// Test DataSubjectRightCancelExportRequest
        /// </summary>
        [Test]
        public void DataSubjectRightCancelExportRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? token = null;
            //var response = instance.DataSubjectRightCancelExportRequest(token);
            //Assert.IsInstanceOf<InlineResponse202> (response, "response is InlineResponse202");
        }
        /// <summary>
        /// Test DataSubjectRightDeleteRequest
        /// </summary>
        [Test]
        public void DataSubjectRightDeleteRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DataSubjectRightDeleteRequest();
            //Assert.IsInstanceOf<InlineResponse202> (response, "response is InlineResponse202");
        }
        /// <summary>
        /// Test DataSubjectRightDeleteStatusRequest
        /// </summary>
        [Test]
        public void DataSubjectRightDeleteStatusRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? token = null;
            //string email = null;
            //var response = instance.DataSubjectRightDeleteStatusRequest(token, email);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        /// <summary>
        /// Test DataSubjectRightExportRequest
        /// </summary>
        [Test]
        public void DataSubjectRightExportRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DataSubjectRightExportRequest();
            //Assert.IsInstanceOf<InlineResponse202> (response, "response is InlineResponse202");
        }
        /// <summary>
        /// Test DataSubjectRightExportStatusRequest
        /// </summary>
        [Test]
        public void DataSubjectRightExportStatusRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? token = null;
            //var response = instance.DataSubjectRightExportStatusRequest(token);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
    }

}