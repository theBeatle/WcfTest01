﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfKnownTypes
{
    public static class SoftServDB
    {
        public static List<Worker> WorkersDB()
        {
            List<Worker> list = new List<Worker>();
            list.Add(new Swarschik{ Id=1, Name="Petro", HasSwarka=true, Salary=10000m, ElektrodQuantity=5 });
            list.Add(new Swarschik { Id = 2, Name = "Ivan", HasSwarka = false, Salary = 3200m, ElektrodQuantity = 0 });
            list.Add(new Swarschik { Id = 3, Name = "Vasja", HasSwarka = true, Salary = 15000m, ElektrodQuantity = 50 });
            list.Add(new Swarschik { Id = 4, Name = "Hose", HasSwarka = true, Salary = 100000m, ElektrodQuantity = 0 });
            list.Add(new Yborschik { Id = 5, Name = "Huan", Salary = 1000000m, IsMitlaOwner = true, DlinaMitlu= 2 });
            list.Add(new Yborschik { Id = 6, Name = "Antonio", Salary = 100000m, IsMitlaOwner = false, DlinaMitlu = 3 });
            list.Add(new Yborschik { Id = 7, Name = "Pedro", Salary = 50000m, IsMitlaOwner = true, DlinaMitlu = 5 });
            list.Add(new Yborschik { Id = 8, Name = "Shtirlic", Salary = 30000m, IsMitlaOwner = false, DlinaMitlu = 2 });
            list.Add(new Santechnik { Id = 9, Name = "Bogdanio", IsVantuzOwner = true, IsRazvodnujKeyOwner= true, Salary = 50000m });
            list.Add(new Santechnik { Id = 10, Name = "Mario", IsVantuzOwner = false, IsRazvodnujKeyOwner = true, Salary = 80000m });
            list.Add(new Santechnik { Id = 11, Name = "Ricardo", IsVantuzOwner = true, IsRazvodnujKeyOwner = false, Salary = 25000m });
            return list;
        }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void ExceptionGenerator()
        {
            try
            {
                throw new MySuper("exception from nothing");
            }
            catch (MySuper err)
            {
                MyWcfSuperPuperException ex = new MyWcfSuperPuperException();
                ex.Result = false;
                ex.Message = err.Message;
                ex.Description = "Htos' naplyguv, ajajaj ((((";

                throw new FaultException<MyWcfSuperPuperException>(ex, new FaultReason(" bebebe"));
            }
            
        }

        public decimal GetHighestSalary()
        {
            return SoftServDB.WorkersDB().Max(w => w.Salary);
        }

        public string GetRichestWorkerName()
        {
            return SoftServDB.WorkersDB()
                .OrderByDescending(w => w.Salary).FirstOrDefault().Name;
            //return SoftServDB.WorkersDB()
            //    .FirstOrDefault(w => w.Salary == SoftServDB.WorkersDB().Max(s => s.Salary)).Name;
            //return SoftServDB.WorkersDB().Select( w => w.Name.Where( s => s. ) )
        }

        public Swarschik[] GetTop3SwarschiksBySalary()
        {
            return SoftServDB.WorkersDB()
                .OfType<Swarschik>()
                .OrderByDescending(s => s.Salary)
                .Take(3)
                .ToArray();
        }

        public Worker[] GetTop5WorkersBySalary()
        {
            SoftServDB.WorkersDB()
           .OrderByDescending(s => s.Salary)
           .Take(5)
           .ToList().
           ForEach( w => Debug.WriteLine($" {w.GetType().Name}") );




            return SoftServDB.WorkersDB()
               .OrderByDescending(s => s.Salary)
               .Take(5)
               .ToArray();
        }

        public int GetWorkersQuantity()
        {
            return SoftServDB.WorkersDB().Count();
        }

        public int GetWorkersQuantityByName(string name)
        {
            var workersCount = SoftServDB.WorkersDB().Where(w => w.Name == name).Count();
            try
            {
                if (workersCount == 0)
                {
                    throw new NameAbsenceException(name);
                }

            }
            catch (NameAbsenceException err)
            {
                var fault = new NameAbsenceFault();
                fault.Result = false;
                fault.Message = err.Message;
                fault.Description = "Such name doesn't exits in the current context!!!";
                var reason = new FaultReason(err.Message);
                throw new FaultException<NameAbsenceFault>(fault, reason);
            }
           
            return workersCount;
        }
    }
    public class MySuper : Exception
    {
        public MySuper(string error)
        {
            Source = error;
           
        }
    }

    [DataContract]
    public class MyWcfSuperPuperException
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Description { get; set; }
    }

}
