using IndianStateCensusAnalyser;
using IndianStateCensusAnalyser.DTO;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\WrongIndiaStateCensusData.csv";
        static string delimiterIndianCensusFilePath = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\DelimiterIndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\IndiaData.csv";
        static string wrongIndianStateCensusFileType = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\IndiaStateCensusData.txt";
        static string indianStateCodeFilePath = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\IndiaStateCode.csv";
        static string wrongIndianStateCodeFileType = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\IndiaStateCode.txt";
        static string delimiterIndianStateCodeFilePath = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\DelimiterIndiaStateCode.csv";
        static string wrongHeadeStateCodeFilePath = @"C:\Users\HP LAPTOP\source\repos\IndianStateCensusAnalyser\NUnitTestProject1\CSVFiles\WrongIndiaStateCode.csv";

        IndianStateCensusAnalyser.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        [Test]
        public void GivenIndianCensusDataFile_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(29, totalRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}