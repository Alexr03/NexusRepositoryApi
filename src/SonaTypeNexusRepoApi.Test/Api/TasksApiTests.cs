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
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TasksApiTests
    {
        private TasksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TasksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TasksApi
            //Assert.IsInstanceOfType(typeof(TasksApi), instance, "instance is a TasksApi");
        }

        
        /// <summary>
        /// Test GetTaskById
        /// </summary>
        [Test]
        public void GetTaskByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetTaskById(id);
            //Assert.IsInstanceOf<TaskXO> (response, "response is TaskXO");
        }
        
        /// <summary>
        /// Test GetTasks
        /// </summary>
        [Test]
        public void GetTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //var response = instance.GetTasks(type);
            //Assert.IsInstanceOf<PageTaskXO> (response, "response is PageTaskXO");
        }
        
        /// <summary>
        /// Test Run
        /// </summary>
        [Test]
        public void RunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.Run(id);
            
        }
        
        /// <summary>
        /// Test Stop
        /// </summary>
        [Test]
        public void StopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.Stop(id);
            
        }
        
    }

}