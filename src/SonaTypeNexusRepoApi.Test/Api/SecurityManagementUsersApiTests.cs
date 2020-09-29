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
    ///  Class for testing SecurityManagementUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SecurityManagementUsersApiTests
    {
        private SecurityManagementUsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SecurityManagementUsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SecurityManagementUsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecurityManagementUsersApi
            //Assert.IsInstanceOfType(typeof(SecurityManagementUsersApi), instance, "instance is a SecurityManagementUsersApi");
        }

        
        /// <summary>
        /// Test ChangePassword
        /// </summary>
        [Test]
        public void ChangePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string body = null;
            //instance.ChangePassword(userId, body);
            
        }
        
        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiCreateUser body = null;
            //var response = instance.CreateUser(body);
            //Assert.IsInstanceOf<ApiUser> (response, "response is ApiUser");
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //instance.DeleteUser(userId);
            
        }
        
        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Test]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string source = null;
            //var response = instance.GetUsers(userId, source);
            //Assert.IsInstanceOf<List<ApiUser>> (response, "response is List<ApiUser>");
        }
        
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //ApiUser body = null;
            //instance.UpdateUser(userId, body);
            
        }
        
    }

}
