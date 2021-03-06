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
    ///  Class for testing ComponentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ComponentsApiTests
    {
        private ComponentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ComponentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ComponentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ComponentsApi
            //Assert.IsInstanceOfType(typeof(ComponentsApi), instance, "instance is a ComponentsApi");
        }

        
        /// <summary>
        /// Test DeleteComponent
        /// </summary>
        [Test]
        public void DeleteComponentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteComponent(id);
            
        }
        
        /// <summary>
        /// Test GetComponentById
        /// </summary>
        [Test]
        public void GetComponentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetComponentById(id);
            //Assert.IsInstanceOf<ComponentXO> (response, "response is ComponentXO");
        }
        
        /// <summary>
        /// Test GetComponents
        /// </summary>
        [Test]
        public void GetComponentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string repository = null;
            //string continuationToken = null;
            //var response = instance.GetComponents(repository, continuationToken);
            //Assert.IsInstanceOf<PageComponentXO> (response, "response is PageComponentXO");
        }
        
        /// <summary>
        /// Test UploadComponent
        /// </summary>
        [Test]
        public void UploadComponentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string repository = null;
            //string yumDirectory = null;
            //System.IO.Stream yumAsset = null;
            //string yumAssetFilename = null;
            //System.IO.Stream dockerAsset = null;
            //System.IO.Stream rAsset = null;
            //string rAssetPathId = null;
            //System.IO.Stream pypiAsset = null;
            //System.IO.Stream aptAsset = null;
            //System.IO.Stream rubygemsAsset = null;
            //System.IO.Stream npmAsset = null;
            //System.IO.Stream nugetAsset = null;
            //System.IO.Stream helmAsset = null;
            //string rawDirectory = null;
            //System.IO.Stream rawAsset1 = null;
            //string rawAsset1Filename = null;
            //System.IO.Stream rawAsset2 = null;
            //string rawAsset2Filename = null;
            //System.IO.Stream rawAsset3 = null;
            //string rawAsset3Filename = null;
            //string maven2GroupId = null;
            //string maven2ArtifactId = null;
            //string maven2Version = null;
            //bool? maven2GeneratePom = null;
            //string maven2Packaging = null;
            //System.IO.Stream maven2Asset1 = null;
            //string maven2Asset1Classifier = null;
            //string maven2Asset1Extension = null;
            //System.IO.Stream maven2Asset2 = null;
            //string maven2Asset2Classifier = null;
            //string maven2Asset2Extension = null;
            //System.IO.Stream maven2Asset3 = null;
            //string maven2Asset3Classifier = null;
            //string maven2Asset3Extension = null;
            //instance.UploadComponent(repository, yumDirectory, yumAsset, yumAssetFilename, dockerAsset, rAsset, rAssetPathId, pypiAsset, aptAsset, rubygemsAsset, npmAsset, nugetAsset, helmAsset, rawDirectory, rawAsset1, rawAsset1Filename, rawAsset2, rawAsset2Filename, rawAsset3, rawAsset3Filename, maven2GroupId, maven2ArtifactId, maven2Version, maven2GeneratePom, maven2Packaging, maven2Asset1, maven2Asset1Classifier, maven2Asset1Extension, maven2Asset2, maven2Asset2Classifier, maven2Asset2Extension, maven2Asset3, maven2Asset3Classifier, maven2Asset3Extension);
            
        }
        
    }

}
