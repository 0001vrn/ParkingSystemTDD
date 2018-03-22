using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDParking;

namespace TDDParkingTest
{
    /// <summary>
    /// Summary description for SlotTest
    /// </summary>
    [TestClass]
    public class SlotTest
    {
        Slots slot; 

        [TestInitialize]
        public void TestInitialize() {
            slot = new Slots();
        }

        [TestMethod]
        public void DoesSlotExist()
        {
            Assert.IsNotNull(slot);
        }

        [TestMethod]
        public void CannotAddCarsBeyondSlots()
        {
            //Arrange
            slot.OccupiedCarSlots =  20;

            //Act
            var isCarAdded = slot.AddCarInSlot();
            //assert
            Assert.IsFalse(isCarAdded);
        }

        [TestMethod]
        public void CanAddCarsWithinSlots()
        {
            //Arrange
            slot.OccupiedCarSlots = 0;

            //Act
            var isCarAdded = slot.AddCarInSlot();
            //assert
            Assert.IsTrue(isCarAdded);
        }

        [TestMethod]
        public void IsCountUpdatedOnAddCar()
        {
            //Arrange
            slot.OccupiedCarSlots = 0;

            //Act
            var isCarAdded = slot.AddCarInSlot();
            //assert
            Assert.AreEqual(19,slot.AvailableCarSlots);
        }

        [TestMethod]
        public void IsCountUpdatedOnRemoveCar()
        {
            //Arrange
            slot.OccupiedCarSlots = 10;

            //Act
            var isCarRemoved = slot.RemoveCarFromSlot();
            //assert
            Assert.AreEqual(11, slot.AvailableCarSlots);
        }

        [TestMethod]
        public void CannotRemoveCarFromEmptyParking()
        {
            //Arrange
            slot.OccupiedCarSlots = 0;

            //Act
            var isCarRemoved = slot.RemoveCarFromSlot();
            //assert
            Assert.IsFalse(isCarRemoved);
        }
    }
}
