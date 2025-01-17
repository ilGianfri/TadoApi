﻿using KoenZomers.Tado.Api.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace KoenZomers.Tado.Api.UnitTest
{
    /// <summary>
    /// Unit Tests for retrieving data from the Tado API
    /// </summary>
    [TestClass]
    public class DataRetrievalTest : BaseTest
    {
        /// <summary>
        /// Tado Session to use for all tests
        /// </summary>
        private static Session session;

        /// <summary>
        /// Sets up a session to be used by all test methods in this class
        /// </summary>
        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext) 
        {
            session = new Session(Username, Password);
            await session.Authenticate();
        }

        /// <summary>
        /// Cleans up the session that was used by all test methods in this class
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup() 
        {
            session.Dispose();
        }

        /// <summary>
        /// Test if information about the current Tado account can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetMeTest()
        {
            Entities.User response = await session.GetMe();
            Assert.IsNotNull(response, "Failed to retrieve information about the current user");
        }

        /// <summary>
        /// Test if the zones can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetZonesTest()
        {
            Entities.Zone[] response = await session.GetZones(HomeId);
            Assert.IsNotNull(response, "Failed to retrieve information about the zones");
        }

        /// <summary>
        /// Test if the Tado devices can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetDevicesTest()
        {
            Entities.Device[] response = await session.GetDevices(HomeId);
            Assert.IsNotNull(response, "Failed to retrieve information about the Tado devices");
        }

        /// <summary>
        /// Test if the mobile devices can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetMobileDevicesTest()
        {
            Entities.MobileDevice.Item[] response = await session.GetMobileDevices(HomeId);
            Assert.IsNotNull(response, "Failed to retrieve information about the mobile devices");
        }

        /// <summary>
        /// Test if the installations can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetInstallationsTest()
        {
            Entities.Installation[] response = await session.GetInstallations(HomeId);
            Assert.IsNotNull(response, "Failed to retrieve information about the installations");
        }

        /// <summary>
        /// Test if the state of the zone can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetZoneStateTest()
        {
            Entities.State response = await session.GetZoneState(HomeId, ZoneId);
            Assert.IsNotNull(response, "Failed to retrieve information about the state of the zone");
        }

        /// <summary>
        /// Test if the home state can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetHomeStateTest()
        {
            Entities.HomeState response = await session.GetHomeState(HomeId);
            Assert.IsNotNull(response, "Failed to retrieve information about the home state");
        }

        /// <summary>
        /// Test if the summarized state of a zone can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetSummarizedZoneStateTest()
        {
            Entities.ZoneSummary response = await session.GetSummarizedZoneState(HomeId, ZoneId);
            Assert.IsNotNull(response, "Failed to retrieve information about the summarized state of the zone");
        }

        /// <summary>
        /// Test if the current weahter at the house can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetWeatherTest()
        {
            Entities.Weather response = await session.GetWeather(HomeId);
            Assert.IsNotNull(response, "Failed to retrieve information about the current weather at the house");
        }

        /// <summary>
        /// Test if the house details can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetHomeTest()
        {
            Entities.House response = await session.GetHome(HomeId);

            Assert.IsNotNull(response, "Failed to retrieve information about the house");
        }

        /// <summary>
        /// Test if the users with access to a house can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetUsersTest()
        {
            Entities.User[] response = await session.GetUsers(HomeId);

            Assert.IsNotNull(response, "Failed to retrieve information about the users with access to a house");
        }

        /// <summary>
        /// Test if the settings of a mobile device registered to a house can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetMobileDeviceSettingsTest()
        {
            Entities.MobileDevice.Settings response = await session.GetMobileDeviceSettings(HomeId, MobileDeviceId);

            Assert.IsNotNull(response, "Failed to retrieve information about the settings of a mobile device registered to a house");
        }

        /// <summary>
        /// Test if the capabilities of a zone registered to a house can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetZoneCapabilitiesTest()
        {
            Entities.Capability response = await session.GetZoneCapabilities(HomeId, ZoneId);

            Assert.IsNotNull(response, "Failed to retrieve information about the capabilities of a zone");
        }

        /// <summary>
        /// Test if the early start setting of a zone registered to a house can be retrieved
        /// </summary>
        [TestMethod]
        public async Task GetEarlyStartTest()
        {
            Entities.EarlyStart response = await session.GetEarlyStart(HomeId, ZoneId);

            Assert.IsNotNull(response, "Failed to retrieve information about the early start setting of a zone");
        }

        /// <summary>
        /// Test to show how IsOpenWindowDetected can be used on a zone's state.
        /// </summary>
        [TestMethod]
        public async Task IsOpenWindowDetectedTest()
        {
            Entities.State response = await session.GetZoneState(HomeId, ZoneId);

            Assert.IsInstanceOfType(response.OpenWindowDetected, typeof(bool));
        }

        /// <summary>
        /// Test to show how IsOpenWindowDetected can be used on a zone's state.
        /// </summary>
        [TestMethod]
        public async Task GetZoneTemperatureOffset()
        {
            Entities.Zone[] zones = await session.GetZones(HomeId);
            Entities.Zone zone = zones.FirstOrDefault(z => z.Id == ZoneId);
            Entities.Temperature response = await session.GetZoneTemperatureOffset(zone.Devices[0]);

            Assert.IsNotNull(response.Celsius);
        }
    }
}
