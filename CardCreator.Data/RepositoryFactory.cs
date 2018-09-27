using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardCreator.Interfaces;



namespace CardCreator.Data
{
    public static class RepositoryFactory
    {
        public static IAlienRepository CreateAlienRepo()
        {
            IAlienRepository repo;
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            switch (mode)
            {
                case "Test":

                    repo = new AlienTestRepository();
                    break;
                case "Prod":
                    repo = new AlienProdRepository();
                    break;
                default:
                    throw new Exception("Mode Value in App Config is not valid.");
            }
            return repo;
        }
        //public static IJobRepository CreateJobRepo()
        //{
        //    IJobRepository repo;
        //    string mode = ConfigurationManager.AppSettings["Mode"].ToString();
        //    switch (mode)
        //    {
        //        case "Test":
        //            repo = new JobTestRepository();
        //            break;
        //        case "Prod":
        //            repo = new JobProdRepository();
        //            break;
        //        default:
        //            throw new Exception("Mode Value in App Config is not valid.");
        //    }
        //    return repo;
        //}
        //public static IBoostRepository CreateBoostRepo()
        //{
        //    IBoostRepository repo;
        //    string mode = ConfigurationManager.AppSettings["Mode"].ToString();
        //    switch (mode)
        //    {
        //        case "Test":
        //            repo = new BoostTestRepository();
        //            break;
        //        case "Prod":
        //            repo = new BoostProdRepository();
        //            break;
        //        default:
        //            throw new Exception("Mode Value in App Config is not valid.");
        //    }
        //    return repo;
        //}
        //public static IEventRepository CreateEventRepo()
        //{
        //    IEventRepository repo;
        //    string mode = ConfigurationManager.AppSettings["Mode"].ToString();
        //    switch (mode)
        //    {
        //        case "Test":
        //            repo = new EventTestRepository();
        //            break;
        //        case "Prod":
        //            repo = new EventProdRepository();
        //            break;
        //        default:
        //            throw new Exception("Mode Value in App Config is not valid.");
        //    }
        //    return repo;
        //}
    }
}
