/* 
 * Nexus Repository Manager REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.26.1-02
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

using SonaTypeNexusRepoApi.Client;
using SonaTypeNexusRepoApi.Api;
using SonaTypeNexusRepoApi.Model;

namespace SonaTypeNexusRepoApi.Test
{
    /// <summary>
    ///  Class for testing SecurityManagementRealmsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SecurityManagementRealmsApiTests
    {
        private SecurityManagementRealmsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SecurityManagementRealmsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SecurityManagementRealmsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecurityManagementRealmsApi
            //Assert.IsInstanceOfType(typeof(SecurityManagementRealmsApi), instance, "instance is a SecurityManagementRealmsApi");
        }

        
        /// <summary>
        /// Test GetActiveRealms
        /// </summary>
        [Test]
        public void GetActiveRealmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetActiveRealms();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetRealms
        /// </summary>
        [Test]
        public void GetRealmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRealms();
            //Assert.IsInstanceOf<List<RealmApiXO>> (response, "response is List<RealmApiXO>");
        }
        
        /// <summary>
        /// Test SetActiveRealms
        /// </summary>
        [Test]
        public void SetActiveRealmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //instance.SetActiveRealms(body);
            
        }
        
    }

}
