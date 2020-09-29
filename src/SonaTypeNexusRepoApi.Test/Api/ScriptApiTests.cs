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
    ///  Class for testing ScriptApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ScriptApiTests
    {
        private ScriptApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScriptApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScriptApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ScriptApi
            //Assert.IsInstanceOfType(typeof(ScriptApi), instance, "instance is a ScriptApi");
        }

        
        /// <summary>
        /// Test Add
        /// </summary>
        [Test]
        public void AddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ScriptXO body = null;
            //instance.Add(body);
            
        }
        
        /// <summary>
        /// Test Browse
        /// </summary>
        [Test]
        public void BrowseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Browse();
            //Assert.IsInstanceOf<List<ScriptXO>> (response, "response is List<ScriptXO>");
        }
        
        /// <summary>
        /// Test Delete1
        /// </summary>
        [Test]
        public void Delete1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.Delete1(name);
            
        }
        
        /// <summary>
        /// Test Edit
        /// </summary>
        [Test]
        public void EditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //ScriptXO body = null;
            //instance.Edit(name, body);
            
        }
        
        /// <summary>
        /// Test Read1
        /// </summary>
        [Test]
        public void Read1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.Read1(name);
            //Assert.IsInstanceOf<ScriptXO> (response, "response is ScriptXO");
        }
        
        /// <summary>
        /// Test Run1
        /// </summary>
        [Test]
        public void Run1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string body = null;
            //var response = instance.Run1(name, body);
            //Assert.IsInstanceOf<ScriptResultXO> (response, "response is ScriptResultXO");
        }
        
    }

}