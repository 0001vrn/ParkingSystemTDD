using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDParking;


namespace TDDParkingTest
{
    [TestClass]
    public class ParkingTest
    {
        Parking parking;
       
      

        [TestInitialize]
        public void Initialize()
        {
            parking = new Parking();
        }
        [TestMethod]
        public void DoesParkingExist()
        {
            //assert
            Assert.IsNotNull(parking);
        }

        [TestMethod]
        public void DoesParkingHaveSlots()
        {
            //assert
            Assert.IsNotNull(parking.Slots);
            
        }

        [TestMethod]
        public void AreTotalBikeSlotsMoreThanZero()
        {
            //assert
            Assert.IsNotNull(parking.Slots.TotalBikeSlots);

        }

        [TestMethod]
        public void AreTotalCarSlotsMoreThanZero()
        {
            //assert
            Assert.IsNotNull(parking.Slots.TotalCarSlots);
        }

        [TestMethod]
        public void AreAvailableBikeSlotsEqualToTotalBikeSlotsWhenEmpty()
        {
            // assert
            Assert.AreEqual(parking.Slots.AvailableBikeSlots, parking.Slots.TotalBikeSlots);
           

        }

        [TestMethod]
        public void AreAvailableCarSlotsEqualToTotalCarSlotsWhenEmpty()
        {
            // assert
            Assert.AreEqual(parking.Slots.AvailableCarSlots, parking.Slots.TotalCarSlots);
        }

        [TestMethod]
        public void DoesReturnTrueWhenCarSlotAvailable()
        {

            //arrange
            parking.Slots.OccupiedCarSlots = 10;

            //act
            bool isAdded = parking.IsCarSlotAvailable();

            //Assert
            Assert.IsTrue(isAdded);

        }

        [TestMethod]
        public void DoesReturnFalseWhenCarSlotUnavailable()
        {

            //arrange
            parking.Slots.OccupiedCarSlots = 20;

            //act
            bool isAdded = parking.IsCarSlotAvailable();

            //Assert
            Assert.IsFalse(isAdded);

        }


        [TestMethod]
        public void DoesReturnTrueWhenBikeSlotAvailable()
        {

            //arrange
            parking.Slots.OccupiedBikeSlots = 10;

            //act
            bool isAdded = parking.IsBikeSlotAvailable();

            //Assert
            Assert.IsTrue(isAdded);

        }

        [TestMethod]
        public void DoesReturnFalseWhenBikeSlotUnavailable()
        {

            //arrange
            parking.Slots.OccupiedBikeSlots = 20;

            //act
            bool isAdded = parking.IsBikeSlotAvailable();

            //Assert
            Assert.IsFalse(isAdded);

        }


        [TestMethod]
        public void DoesAddCarUpdateValues()
        {

            //arrange
            parking.Slots.OccupiedCarSlots = 10;

            //act
            var availableCount = parking.AddCarInParking();


            //Assert
            Assert.AreEqual(9, availableCount);

        }


        [TestMethod]
        public void DoesAddBikeUpdateValues()
        {

            //arrange
            parking.Slots.OccupiedBikeSlots = 10;

            //act
            var availableCount = parking.AddBikeInParking();


            //Assert
            Assert.AreEqual(9, availableCount);

        }

    }
} 
