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
    ///  Class for testing AssetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AssetsApiTests
    {
        private AssetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AssetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AssetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AssetsApi
            //Assert.IsInstanceOfType(typeof(AssetsApi), instance, "instance is a AssetsApi");
        }

        
        /// <summary>
        /// Test DeleteAsset
        /// </summary>
        [Test]
        public void DeleteAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteAsset(id);
            
        }
        
        /// <summary>
        /// Test GetAssetById
        /// </summary>
        [Test]
        public void GetAssetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetAssetById(id);
            //Assert.IsInstanceOf<AssetXO> (response, "response is AssetXO");
        }
        
        /// <summary>
        /// Test GetAssets
        /// </summary>
        [Test]
        public void GetAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string repository = null;
            //string continuationToken = null;
            //var response = instance.GetAssets(repository, continuationToken);
            //Assert.IsInstanceOf<PageAssetXO> (response, "response is PageAssetXO");
        }
        
    }

}
