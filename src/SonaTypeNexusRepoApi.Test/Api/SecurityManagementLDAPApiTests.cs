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
    ///  Class for testing SecurityManagementLDAPApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SecurityManagementLDAPApiTests
    {
        private SecurityManagementLDAPApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SecurityManagementLDAPApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SecurityManagementLDAPApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecurityManagementLDAPApi
            //Assert.IsInstanceOfType(typeof(SecurityManagementLDAPApi), instance, "instance is a SecurityManagementLDAPApi");
        }

        
        /// <summary>
        /// Test ChangeOrder
        /// </summary>
        [Test]
        public void ChangeOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //instance.ChangeOrder(body);
            
        }
        
        /// <summary>
        /// Test CreateLdapServer
        /// </summary>
        [Test]
        public void CreateLdapServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateLdapServerXo body = null;
            //instance.CreateLdapServer(body);
            
        }
        
        /// <summary>
        /// Test DeleteLdapServer
        /// </summary>
        [Test]
        public void DeleteLdapServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.DeleteLdapServer(name);
            
        }
        
        /// <summary>
        /// Test GetLdapServer
        /// </summary>
        [Test]
        public void GetLdapServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.GetLdapServer(name);
            
        }
        
        /// <summary>
        /// Test GetLdapServers
        /// </summary>
        [Test]
        public void GetLdapServersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetLdapServers();
            
        }
        
        /// <summary>
        /// Test UpdateLdapServer
        /// </summary>
        [Test]
        public void UpdateLdapServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //UpdateLdapServerXo body = null;
            //instance.UpdateLdapServer(name, body);
            
        }
        
    }

}