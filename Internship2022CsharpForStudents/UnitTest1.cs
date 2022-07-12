using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Internship2022CsharpForStudents
{
    [TestClass]
    public class LinqTasks
    {
        List<string> items = new List<string>()
        {
            "Infobip HR",
            "Infobip UK",
            "Infobip Japan",
            "Infobip US OpenMarket branch",
            "Infobip Japan",
            "Infobip US"
        };

        List<string> items2 = new List<string>()
        {
            "Infobip HR",
            "Infobip Japan",
            "Infobip Japan",
            "Infobip Canada"
        };

        List<string> employees = new List<string>()
        {
            "Silvio",
            "Siniša",
            "Eugen"
        };

        List<string[]> emptyItems = new List<string[]>();

        List<Company> companies = new List<Company>()
        {
            new Company() { Name ="Infobip US", Id =1},
            new Company() { Name ="Infobip Germany", Id =2},
            new Company() { Name ="Infobip Canada", Id =3}

        };

        List<Client> clients = new List<Client>() {
            new Client() { Id = 1, ClientName="Facebook", CompanyId=1, Income=100000M },
            new Client() { Id = 1, ClientName="Amazon", CompanyId=1, Income =2000000M },
            new Client() { Id = 1, ClientName="T-Mobile", CompanyId=2, Income=50000M },
            new Client() { Id = 1, ClientName="Telemach", CompanyId=2, Income=14000M },
            new Client() { Id = 1, ClientName="A1", CompanyId=4, Income=9000M },
            new Client() { Id = 1, ClientName="Italia One", CompanyId=40, Income=19000M }
        };


        [TestInitialize]
        public void Prepare()
        {

        }

        [TestMethod]
        public void IsFirstItemInfobipHR()
        {
            const string shouldBe = "Infobip HR";

            Assert.AreEqual(firstItem, shouldBe);
        }


        [TestMethod]
        public void FirstItemOfEmptyItemsShouldReturnNull()
        {
            //Accessing first item of EmptyItems should return null and not throw exception
            const string shouldBe = null;

            Assert.AreEqual(compareThis, shouldBe);
        }


        [TestMethod]
        public void FirstItemThatContainsTextUS()
        {
            //First item that contains text US should be ...
            const string shouldBe = "Infobip US OpenMarket branch";
            
            Assert.AreEqual(item, shouldBe);
        }


        [TestMethod]
        public void ShouldReturnLastItem()
        {
            //First item that contains text US should be ...
            const string shouldBe = "Infobip US";
            
            Assert.AreEqual(item, shouldBe);
        }



        [TestMethod]
        public void ShouldReturnLastItemFromEmpty()
        {
            //Accessing last item of EmptyItems should return null and not throw exception
            const string shouldBe = null;
            
            Assert.AreEqual(item, shouldBe);
        }


        [TestMethod]

        public void ShouldReturnLastContainingText()
        {
            //Find last item that contains text US
            const string shouldBe = "Infobip US";
            
            Assert.AreEqual(item, shouldBe);
        }

        [TestMethod]

        public void ShouldThrowException()
        {
            //Find item that containse text US. If exists more than one or none throw exception            
            
            Assert.ThrowsException<InvalidOperationException>(action);
        }

        [TestMethod]
        public void ShouldReturnUKcompany()
        {
            //Find item that contains text UK. If more than one found or none throw exception.
            const string shouldBe = "Infobip UK";
            
            Assert.AreEqual(item, shouldBe);
        }

        [TestMethod]
        public void ShouldReturnNull()
        {
            //Find item that contains not existing text. When not found return null. Don't throw exception.
            const string shouldBe = null;
            
            Assert.AreEqual(item, shouldBe);
        }

        [TestMethod]
        public void ShoudlReturnUniqueItems()
        {
            //Return only unique items from Items. No duplicates allowed.
            const int countShouldBe = 5;
            
            Assert.AreEqual(result.Count(), countShouldBe);
        }

        [TestMethod]
        public void ShoudlReturnOnlyUniqueToItems()
        {
            //Return only items that exist in Items and don't exist in Items2
            const int countShouldBe = 3;
            
            Assert.AreEqual(result.Count(), countShouldBe);
        }

        [TestMethod]
        public void ShouldReturnOnlySharedItems()
        {
            //Return only unique items that exist both in Items and in Items2. 
            const int countShouldBe = 2;
            
            Assert.AreEqual(result.Count(), countShouldBe);
        }

        [TestMethod]
        public void ShoudlReturnCombination()
        {
            //Return items that exist both in Items and in Items2. Remove duplicates.
            const int countShouldBe = 6;
            
            Assert.AreEqual(result.Count(), countShouldBe);
        }

        [TestMethod]
        public void ShouldReturnOnlyUKandUS()
        {
            //Return only items from Items that contain text US or contain text UK
            const int countShouldBe = 3;
            
            Assert.AreEqual(result.Count(), countShouldBe);
        }

        [TestMethod]
        public void ShouldReturnOnlyOddIdexes()
        {
            //Return only items from Items that have odd index numbers ( 0, 2, 4 ...) and contain text "Infobip"
            const int countShouldBe = 3;
            
            Assert.AreEqual(result.Count(), countShouldBe);
        }

        [TestMethod]
        public void ShouldConfirmAllHaveInfobip()
        {
            //Confirm that all members of Items contain text "Infobip
            const bool resultShouldBe = true;
            
            Assert.AreEqual(result, resultShouldBe);
        }

        [TestMethod]
        public void ShouldConfirmThatAtLeastOneHasText()
        {
            //Confirm that at least one or more members of Items contain text Japan
            const bool resultShouldBe = true;
            
            Assert.AreEqual(result, resultShouldBe);
        }

        [TestMethod]
        public void ShouldConfirmThatLastOddMemberExistsInItems()
        {
            //Filter Items2 to only members with odd index. Take last from them. Confirm that this item exists in Items collection.
            const bool resultShouldBe = true;
            
            Assert.AreEqual(result, resultShouldBe);
        }


        [TestMethod]
        public void ShouldReturnNewItemsWithOnlyCapitalWords()
        {
            //Create new list using only Items members that have even index. Parse original values so that new members consist of only capital letters and dot separators. Also prefix each new member with index.
            //  Result list should be like this:
            //[0]: "0.I.H"
            //[1]: "1.I.J"
            //[2]: "2.I.J"

            const int resultShouldBe = 3;
            
            
            Assert.AreEqual(result.Count(), resultShouldBe);
        }


        [TestMethod]
        public void ShouldReturnAllCombinationsOfCompanyAndEmployee()
        {
            //Create new list. It should contain all combinations of Items and Employees. So each member of Item should be paired with each member or Employees (cartesian product)
            //example of new list:  "Infobip HR - Silvio","Infobip HR - Eugen" ...  "Infobip US - Eugen" etc.
            const int resultShouldBe = 18;
            
            Assert.AreEqual(result.Count(), resultShouldBe);
        }

        [TestMethod]
        public void ShouldReturnMixOfItems()
        {
            // Create new list using members of Items. Order items descending. Then project into new list only items with index 1,2.

            //Result list should contain: 
            //[0]: "Infobip US"
            //[1]: "Infobip UK"

            const int resultShouldBe = 2;
            
            Assert.AreEqual(result.Count(), resultShouldBe);
        }

        [TestMethod]
        public void ShouldReturnJoinOfCompaniesAndClients()
        {
            // Create new list of strings. Make join between Companies and Clients on key Companies.Id => Client.CompanyId.            

            //Result should be list of strings:
            //[0]: "Infobip US -> Facebook"
            //[1]: "Infobip US -> Amazon"
            //[2]: "Infobip Germany -> T-Mobile"
            //[3]: "Infobip Germany -> Telemach"
            const int resultShouldBe = 4;
            

            Assert.AreEqual(result.Count(), resultShouldBe);
        }


        [TestMethod]
        public void ShouldReturnGroupJoinOfCompaniesAndClients()
        {
            // Create new list of strings. Make group join between Companies and Clients on key Companies.Id => Client.CompanyId.

            //Result should be list of strings:
            //    [0]: "Infobip US -> Facebook | Amazon"
            //    [1]: "Infobip Germany -> T-Mobile | Telemach"
            //    [2]: "Infobip Canada -> "
            const int resultShouldBe = 3;
            

            Assert.AreEqual(result.Count(), resultShouldBe);
        }


        [TestMethod]
        public void ShouldReturnNumberOfCustomersPerCompany()
        {
            // Create new list of strings. Group clients on CompanyId. Then join them with Company. Finally show company name and number of clients that belong to that company as string.

            //Result should be list of strings:
            //[0]: "Infobip US has 2 clients."
            //[1]: "Infobip Germany has 2 clients."
            const int resultShouldBe = 2;
            


            Assert.AreEqual(result.Count(), resultShouldBe);
        }

        [TestMethod]
        public void ShouldReturnSumOfIncomePerCompany()
        {
            // Create new list of strings. Group clients on CompanyId. Then join them with Company. Finally show company name and sum of income for all clients that belong to that company as string.

            //Result should be list of strings:
            //[0]: "Infobip US has income: 2100000"
            //[1]: "Infobip Germany has income: 64000"
            const int resultShouldBe = 2;
            

            Assert.AreEqual(result.Count(), resultShouldBe);
        }

        [TestMethod]
        public void ShouldReturnAverageIncomeOfClientsWithNoMatchInCompanies()
        {
            //Find all customers that dont have match
            const string resultShouldBe = "Average Income of customers with no Infobip company assigned -> 14.000,00 kn";
            
            Assert.AreEqual(result, resultShouldBe);
        }

        class Company
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class Client
        {
            public int Id { get; set; }
            public int CompanyId { get; set; }
            public string ClientName { get; set; }
            public decimal Income { get; set; }

        }
    }
}