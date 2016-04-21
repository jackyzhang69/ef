using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TRVDomain;
namespace DBContextLayer
{
    public class SPDBContext : DbContext
    {
        public SPDBContext() : base("TRV")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }

        
    }

    public interface IRepository<T> 
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
    }
    public interface IStudentRepository<T>:IRepository<T> where T : Student
    {
        
    }
    public interface IAddressRepository<T>:IRepository<T> where T : Address
    {

    }
    public class StudentRepository : IStudentRepository<Student>
    {
        private SPDBContext spdb;
        public  StudentRepository(SPDBContext context)
        {
            this.spdb = context;
        }
        public IEnumerable<Student> List
        {
            get
            {
                    return spdb.Students; 
            }
        }

        public void Add(Student entity)
        {
                spdb.Students.Add(entity);
                spdb.SaveChanges();
        }

        public void Delete(Student entity)
        {
                spdb.Students.Remove(entity);
                spdb.SaveChanges();
        }

        public Student FindById(int Id)
        {
                return spdb.Students.Where(x => x.PersonId == Id).FirstOrDefault();
        }

        public void Update(Student entity)
        {
                spdb.Entry(entity).State=System.Data.Entity.EntityState.Modified;
                spdb.SaveChanges();
        }
    }

    public class AddressRepository : IAddressRepository<Address>
    {
        private SPDBContext spdb;
        public AddressRepository(SPDBContext context)
        {
            this.spdb = context;
        }
        public IEnumerable<Address> List
        {
            get
            {
                return spdb.Addresses;
            }
        }

        public void Add(Address entity)
        {
            spdb.Addresses.Add(entity);
            spdb.SaveChanges();
        }

        public void Delete(Address entity)
        {
            spdb.Addresses.Remove(entity);
            spdb.SaveChanges();
        }

        public Address FindById(int Id)
        {
            return spdb.Addresses.Where(x => x.AddressId == Id).FirstOrDefault();
        }

        public void Update(Address entity)
        {
            spdb.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            spdb.SaveChanges();
        }
    }
}
