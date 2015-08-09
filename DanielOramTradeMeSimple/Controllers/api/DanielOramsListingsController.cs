using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DanielOramTradeMeSimple.Models;
using DanielOramTradeMeSimple.Controllers;
using System.IO;

namespace DanielOramTradeMeSimple.Controllers.api
{
    public class DanielOramsListingsController : ApiController
    {

        private static readonly DanielOramsListingViewModel[] Listings = {
                                                                            new DanielOramsListingViewModel {
                                                                                Id = 1,
                                                                                Name = "My Ferrari",
                                                                                Featured = false,
                                                                                StartDate = DateTime.Now,
                                                                                Price = 50000


                                                                            },
                                                                            new DanielOramsListingViewModel {
                                                                                Id = 2,
                                                                                Name = "My House",
                                                                                Featured = true,
                                                                                StartDate = DateTime.Now,
                                                                                Price = 500000


                                                                            }
                                                                          };
                  

        // GET api/danieloramslistings
        public IEnumerable<DanielOramsListingViewModel> Get()
        {
            return Listings;
        }


        
        public List<RentDataModel> Handler()
        {
            
            //var reader = new StreamReader(File.OpenRead("~/CSV/detailed-mean-rents-total.csv"));
            List<RentDataModel> listData = new List<RentDataModel>();

            //wile (!reader.EndOfStream)

            String csvf = new csvFile().csvFileData;
            String[] csvArray = csvf.Split('~');

            foreach (string line in csvArray)
            {
                //init rentdata object
                var rentdata = new RentDataModel();

                //read line from csv
                var values = line.Split(',');

                //set values of rentdata object
                rentdata.region = values[0];
                rentdata.marketRentArea = values[1];
                rentdata.propertyType = values[2];
                rentdata.averageRentPrice = float.Parse(values.Last());

                //add rentdata object to list
                listData.Add(rentdata);
                Console.WriteLine(csvArray.Length);
            }
            return listData;
             
        }
        

        public string Get(int id, int id2)
        {
            return "Test Ajax!";
        }
        /*
        //to delete
        public string Get(int id)
        {
            return "Some test data";
        }
        */

        //IMPORTANT
        //return our CSV data
        // GET api/danieloramslistings/5
        
        public List<RentDataModel> Get(int id)
        {
            
            return Handler();
        }
        
        // POST api/danieloramslistings
        public void Post([FromBody]string value)
        {
        }

        // PUT api/danieloramslistings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/danieloramslistings/5
        public void Delete(int id)
        {
        }
    }
}
